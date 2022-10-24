namespace Shutdown_Timer_GUI
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonStartTimer_Click(object sender, EventArgs e)
        {
            long hours = (long)numericUpDownHours.Value;
            long minutes = (long)numericUpDownMinutes.Value;
            long seconds = (long)numericUpDownSeconds.Value;

            long totalTimeInSeconds = (hours * 60 * 60) + (minutes * 60) + seconds;

            switch (comboBoxActions.Text)
            {
                case "Shutdown":
                    Shutdown(totalTimeInSeconds);
                    break;
                case "Restart":
                    Restart(totalTimeInSeconds);
                    break;
                case "Hibernate":
                    Hibernate(totalTimeInSeconds);
                    break ;
                case "Sleep":
                    Sleep(totalTimeInSeconds);
                    break;
                case "Logout":
                    Logout(totalTimeInSeconds);
                    break;
                case "Lock":
                    Lock(totalTimeInSeconds);
                    break;
                default:
                    break;
            }
        }

        private void Lock(long totalTimeInSeconds)
        {
            throw new NotImplementedException();
        }

        private void Logout(long totalTimeInSeconds)
        {
            throw new NotImplementedException();
        }

        private void Hibernate(long totalTimeInSeconds)
        {
            throw new NotImplementedException();
        }

        private void Sleep(long totalTimeInSeconds)
        {
            throw new NotImplementedException();
        }

        private void Restart(long totalTimeInSeconds)
        {
            throw new NotImplementedException();
        }

        private void Shutdown(long totalTimeInSeconds)
        {
            String command = "shutdown -s -t " + totalTimeInSeconds;
            ExecuteCommand(command);
        }

        private void ExecuteCommand(String command)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = command;
            process.StartInfo = startInfo;
            process.Start();
        }
    }
}