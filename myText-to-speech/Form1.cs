using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;

namespace myText_to_speech
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer myspeechSyn = new SpeechSynthesizer();

        public Form1()
        {
            InitializeComponent();
            label1.Text = "Developed By: Saad Bin Shahid @ Saadbinshahid.fb@gmail.com";
        }

        //exit button
        private void button2_Click(object sender, EventArgs e)
        {
            myspeechSyn.Dispose();
            Application.Exit();
        }

        //Speak myText-to-Speach
        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                label1.Text = "Speaking | If you cannot hear, Please check your audio settings.";
                myspeechSyn.Volume = 100;
                myspeechSyn.SpeakAsync(richTextBox1.Text);
            }
            else
            {
                label1.Text = "Please enter some text first !";
            }
        }


    }
}
