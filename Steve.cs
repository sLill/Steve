using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BergPerformanceServices;

namespace Steve
{
    public partial class Steve : Form
    {
        #region Member Variables..
        private CancellationTokenSource _CpuTokenSource;
        #endregion Member Variables..

        #region Constructors..
        public Steve()
        {
            InitializeComponent();

            int r = DoThing();

            //InitializeLoadCpu();

            //var stopwatch = Stopwatch.StartNew();
            //stopwatch.Stop();
            //Debug.WriteLine(stopwatch.Elapsed);

            //stopwatch = Stopwatch.StartNew();
            //stopwatch.Stop();
            //Debug.WriteLine(stopwatch.Elapsed);
        }
        #endregion Constructors..

        private int DoThing()
        {
           
        }

        #region Methods..
        #region Events..
        #region TbCpuUtilization_ValueChanged
        private void TbCpuUtilization_ValueChanged(object sender, EventArgs e)
        {
            lblCpu.Text = $"{tbCpuUtilization.Value.ToString()}%";

            if (_CpuTokenSource != null)
            {
                _CpuTokenSource.Cancel();
                _CpuTokenSource = new CancellationTokenSource();

                LoadCpu(tbCpuUtilization.Value, _CpuTokenSource.Token);
            }

        }
        #endregion TbCpuUtilization_ValueChanged
        #endregion Events..

        #region InitializeLoadCpu
        private void InitializeLoadCpu()
        {
            BergCpuMonitor BergCpuMonitor = new BergCpuMonitor(1000);

            cbCorePreference.SelectedIndex = 0;
            _CpuTokenSource = new CancellationTokenSource();



            _CpuTokenSource = new CancellationTokenSource();
            LoadCpu(0, _CpuTokenSource.Token);
            BergCpuMonitor.EndWatch("Watch1");
        }
        #endregion InitializeLoadCpu

        private void LoadCpu(int percentage, CancellationToken ct)
        {
            int ThreadCount = cbCorePreference.SelectedIndex == 1 ? Environment.ProcessorCount : 1;

            for (int i = 0; i < ThreadCount; i++)
            {
                Task.Run(() =>
                {
                    try
                    {
                        Stopwatch Watch = new Stopwatch();
                        Watch.Start();

                        while (true)
                        {
                            // Make the loop go on for "percentage" milliseconds then sleep the 
                            // remaining percentage milliseconds. So 40% utilization means work 40ms and sleep 60ms
                            if (Watch.ElapsedMilliseconds > percentage)
                            {
                                Thread.Sleep(100 - percentage);
                                Watch.Reset();
                                Watch.Start();
                            }

                            ct.ThrowIfCancellationRequested();
                        }
                    }
                    catch (OperationCanceledException) { }
                }, ct);
            }
        }
        #endregion Methods
    }
}
