namespace Shutdown_Timer_GUI
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelShutdownTimer = new System.Windows.Forms.Label();
            this.groupBoxWhatToDo = new System.Windows.Forms.GroupBox();
            this.checkBoxRunInBackground = new System.Windows.Forms.CheckBox();
            this.checkBoxPreventSystemFromGoingToSleep = new System.Windows.Forms.CheckBox();
            this.checkBoxGraceful = new System.Windows.Forms.CheckBox();
            this.comboBoxActions = new System.Windows.Forms.ComboBox();
            this.labelSelectAnAction = new System.Windows.Forms.Label();
            this.groupBoxWhenToDoIt = new System.Windows.Forms.GroupBox();
            this.numericUpDownSeconds = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinutes = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHours = new System.Windows.Forms.NumericUpDown();
            this.labelSeconds = new System.Windows.Forms.Label();
            this.labelMinutes = new System.Windows.Forms.Label();
            this.labelHours = new System.Windows.Forms.Label();
            this.buttonStartTimer = new System.Windows.Forms.Button();
            this.groupBoxWhatToDo.SuspendLayout();
            this.groupBoxWhenToDoIt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).BeginInit();
            this.SuspendLayout();
            // 
            // labelShutdownTimer
            // 
            this.labelShutdownTimer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelShutdownTimer.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelShutdownTimer.Location = new System.Drawing.Point(12, 9);
            this.labelShutdownTimer.Name = "labelShutdownTimer";
            this.labelShutdownTimer.Size = new System.Drawing.Size(250, 30);
            this.labelShutdownTimer.TabIndex = 0;
            this.labelShutdownTimer.Text = "Shutdown Timer";
            this.labelShutdownTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxWhatToDo
            // 
            this.groupBoxWhatToDo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxWhatToDo.Controls.Add(this.checkBoxRunInBackground);
            this.groupBoxWhatToDo.Controls.Add(this.checkBoxPreventSystemFromGoingToSleep);
            this.groupBoxWhatToDo.Controls.Add(this.checkBoxGraceful);
            this.groupBoxWhatToDo.Controls.Add(this.comboBoxActions);
            this.groupBoxWhatToDo.Controls.Add(this.labelSelectAnAction);
            this.groupBoxWhatToDo.Location = new System.Drawing.Point(12, 42);
            this.groupBoxWhatToDo.Name = "groupBoxWhatToDo";
            this.groupBoxWhatToDo.Size = new System.Drawing.Size(250, 130);
            this.groupBoxWhatToDo.TabIndex = 2;
            this.groupBoxWhatToDo.TabStop = false;
            this.groupBoxWhatToDo.Text = "What to do?";
            // 
            // checkBoxRunInBackground
            // 
            this.checkBoxRunInBackground.AutoSize = true;
            this.checkBoxRunInBackground.Location = new System.Drawing.Point(6, 101);
            this.checkBoxRunInBackground.Name = "checkBoxRunInBackground";
            this.checkBoxRunInBackground.Size = new System.Drawing.Size(127, 19);
            this.checkBoxRunInBackground.TabIndex = 4;
            this.checkBoxRunInBackground.Text = "Run in background";
            this.checkBoxRunInBackground.UseVisualStyleBackColor = true;
            // 
            // checkBoxPreventSystemFromGoingToSleep
            // 
            this.checkBoxPreventSystemFromGoingToSleep.AutoSize = true;
            this.checkBoxPreventSystemFromGoingToSleep.Checked = true;
            this.checkBoxPreventSystemFromGoingToSleep.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPreventSystemFromGoingToSleep.Location = new System.Drawing.Point(6, 76);
            this.checkBoxPreventSystemFromGoingToSleep.Name = "checkBoxPreventSystemFromGoingToSleep";
            this.checkBoxPreventSystemFromGoingToSleep.Size = new System.Drawing.Size(213, 19);
            this.checkBoxPreventSystemFromGoingToSleep.TabIndex = 3;
            this.checkBoxPreventSystemFromGoingToSleep.Text = "Prevent system from going to sleep";
            this.checkBoxPreventSystemFromGoingToSleep.UseVisualStyleBackColor = true;
            // 
            // checkBoxGraceful
            // 
            this.checkBoxGraceful.AutoSize = true;
            this.checkBoxGraceful.Location = new System.Drawing.Point(6, 51);
            this.checkBoxGraceful.Name = "checkBoxGraceful";
            this.checkBoxGraceful.Size = new System.Drawing.Size(204, 19);
            this.checkBoxGraceful.TabIndex = 2;
            this.checkBoxGraceful.Text = "Graceful (do not force close apps)";
            this.checkBoxGraceful.UseVisualStyleBackColor = true;
            // 
            // comboBoxActions
            // 
            this.comboBoxActions.FormattingEnabled = true;
            this.comboBoxActions.Items.AddRange(new object[] {
            "Shutdown",
            "Restart",
            "Hibernate",
            "Sleep",
            "Logout",
            "Lock"});
            this.comboBoxActions.Location = new System.Drawing.Point(105, 22);
            this.comboBoxActions.Name = "comboBoxActions";
            this.comboBoxActions.Size = new System.Drawing.Size(139, 23);
            this.comboBoxActions.TabIndex = 1;
            this.comboBoxActions.Text = "Shutdown";
            // 
            // labelSelectAnAction
            // 
            this.labelSelectAnAction.AutoSize = true;
            this.labelSelectAnAction.Location = new System.Drawing.Point(6, 25);
            this.labelSelectAnAction.Name = "labelSelectAnAction";
            this.labelSelectAnAction.Size = new System.Drawing.Size(93, 15);
            this.labelSelectAnAction.TabIndex = 0;
            this.labelSelectAnAction.Text = "Select an action:";
            // 
            // groupBoxWhenToDoIt
            // 
            this.groupBoxWhenToDoIt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxWhenToDoIt.Controls.Add(this.numericUpDownSeconds);
            this.groupBoxWhenToDoIt.Controls.Add(this.numericUpDownMinutes);
            this.groupBoxWhenToDoIt.Controls.Add(this.numericUpDownHours);
            this.groupBoxWhenToDoIt.Controls.Add(this.labelSeconds);
            this.groupBoxWhenToDoIt.Controls.Add(this.labelMinutes);
            this.groupBoxWhenToDoIt.Controls.Add(this.labelHours);
            this.groupBoxWhenToDoIt.Location = new System.Drawing.Point(12, 178);
            this.groupBoxWhenToDoIt.Name = "groupBoxWhenToDoIt";
            this.groupBoxWhenToDoIt.Size = new System.Drawing.Size(250, 70);
            this.groupBoxWhenToDoIt.TabIndex = 3;
            this.groupBoxWhenToDoIt.TabStop = false;
            this.groupBoxWhenToDoIt.Text = "When to do it?";
            // 
            // numericUpDownSeconds
            // 
            this.numericUpDownSeconds.Location = new System.Drawing.Point(139, 37);
            this.numericUpDownSeconds.Maximum = new decimal(new int[] {
            87599,
            0,
            0,
            0});
            this.numericUpDownSeconds.Name = "numericUpDownSeconds";
            this.numericUpDownSeconds.Size = new System.Drawing.Size(60, 23);
            this.numericUpDownSeconds.TabIndex = 5;
            // 
            // numericUpDownMinutes
            // 
            this.numericUpDownMinutes.Location = new System.Drawing.Point(73, 37);
            this.numericUpDownMinutes.Maximum = new decimal(new int[] {
            87599,
            0,
            0,
            0});
            this.numericUpDownMinutes.Name = "numericUpDownMinutes";
            this.numericUpDownMinutes.Size = new System.Drawing.Size(60, 23);
            this.numericUpDownMinutes.TabIndex = 4;
            // 
            // numericUpDownHours
            // 
            this.numericUpDownHours.Location = new System.Drawing.Point(6, 37);
            this.numericUpDownHours.Maximum = new decimal(new int[] {
            87599,
            0,
            0,
            0});
            this.numericUpDownHours.Name = "numericUpDownHours";
            this.numericUpDownHours.Size = new System.Drawing.Size(60, 23);
            this.numericUpDownHours.TabIndex = 3;
            // 
            // labelSeconds
            // 
            this.labelSeconds.Location = new System.Drawing.Point(139, 19);
            this.labelSeconds.Name = "labelSeconds";
            this.labelSeconds.Size = new System.Drawing.Size(60, 15);
            this.labelSeconds.TabIndex = 2;
            this.labelSeconds.Text = "Seconds";
            this.labelSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMinutes
            // 
            this.labelMinutes.Location = new System.Drawing.Point(73, 19);
            this.labelMinutes.Name = "labelMinutes";
            this.labelMinutes.Size = new System.Drawing.Size(60, 15);
            this.labelMinutes.TabIndex = 1;
            this.labelMinutes.Text = "Minutes";
            this.labelMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHours
            // 
            this.labelHours.Location = new System.Drawing.Point(7, 19);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(59, 15);
            this.labelHours.TabIndex = 0;
            this.labelHours.Text = "Hours";
            this.labelHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonStartTimer
            // 
            this.buttonStartTimer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStartTimer.Location = new System.Drawing.Point(12, 254);
            this.buttonStartTimer.Name = "buttonStartTimer";
            this.buttonStartTimer.Size = new System.Drawing.Size(250, 23);
            this.buttonStartTimer.TabIndex = 0;
            this.buttonStartTimer.Text = "Start Timer";
            this.buttonStartTimer.UseVisualStyleBackColor = true;
            this.buttonStartTimer.Click += new System.EventHandler(this.buttonStartTimer_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 287);
            this.Controls.Add(this.buttonStartTimer);
            this.Controls.Add(this.groupBoxWhenToDoIt);
            this.Controls.Add(this.groupBoxWhatToDo);
            this.Controls.Add(this.labelShutdownTimer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainWindow";
            this.Text = "Shutdown Timer";
            this.groupBoxWhatToDo.ResumeLayout(false);
            this.groupBoxWhatToDo.PerformLayout();
            this.groupBoxWhenToDoIt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label labelShutdownTimer;
        private GroupBox groupBoxWhatToDo;
        private GroupBox groupBoxWhenToDoIt;
        private Button buttonStartTimer;
        private ComboBox comboBoxActions;
        private Label labelSelectAnAction;
        private CheckBox checkBoxRunInBackground;
        private CheckBox checkBoxPreventSystemFromGoingToSleep;
        private CheckBox checkBoxGraceful;
        private NumericUpDown numericUpDownSeconds;
        private NumericUpDown numericUpDownMinutes;
        private NumericUpDown numericUpDownHours;
        private Label labelSeconds;
        private Label labelMinutes;
        private Label labelHours;
    }
}