using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steve
{
    public partial class Steve : Form
    {
        #region Member Variables..
        private CancellationTokenSource _CpuTokenSource;
        #endregion Member Variables..

        #region Constructors..
        #region Steve
        public Steve()
        {
            InitializeComponent();

            InitializeLoadCpu();
        }
        #endregion Steve
        #endregion Constructors..

        #region Methods..
        #region Events..
        #region TbCpuUtilization_ValueChanged
        private void TbCpuUtilization_ValueChanged(object sender, EventArgs e)
        {
            int Value = ((TrackBar)sender).Value;
            lblCpu.Text = $"{Value.ToString()}%";

            _CpuTokenSource.Cancel();
            _CpuTokenSource = new CancellationTokenSource();

            LoadCpu(Value, _CpuTokenSource.Token);
        }
        #endregion TbCpuUtilization_ValueChanged
        #endregion Events..

        #region InitializeLoadCpu
        private void InitializeLoadCpu()
        {
            cbCorePreference.SelectedIndex = 0;

            _CpuTokenSource = new CancellationTokenSource();
            LoadCpu(0, _CpuTokenSource.Token);
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
