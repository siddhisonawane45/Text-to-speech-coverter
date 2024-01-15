using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System. Speech.Recognition;
namespace speechtotext
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != " ")
            {
                SpeechSynthesizer ss = new SpeechSynthesizer();
                ss.Volume = trackBar1.Value;
                ss.Speak(textBox1.Text);


            }
            else
            {
                MessageBox.Show("please write something first");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpeechRecognitionEngine sr = new SpeechRecognitionEngine();
            Grammar word = new DictationGrammar();
            sr.LoadGrammar(word);
            try
            {
                textBox2.Text = "listening now...........";
                sr.SetInputToDefaultAudioDevice();
                RecognitionResult result = sr.Recognize();
                textBox2.Clear();
                textBox2.Text = result.Text;

            }
            catch
            {
                textBox2.Text = " ";
                MessageBox.Show("mic not found");
            }
            finally
            {
                sr.UnloadAllGrammars();
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
