using System;
using EyeXFramework.Forms;
using System.Windows.Forms;
using System.Speech.Recognition;

namespace VoiceClicker
{
	public partial class VoiceClickerForm : Form
	{
		private static readonly SpeechRecognitionEngine Rec = new SpeechRecognitionEngine();
		private static readonly FormsEyeXHost Host = new FormsEyeXHost();

		public VoiceClickerForm()
		{
			InitializeComponent();

			Host.Start();

			Rec.UnloadAllGrammars();
			Rec.LoadGrammar(new Grammar(new Choices("click", "okay")));
			Rec.SpeechRecognized += TriggerActivation;
			Rec.SetInputToDefaultAudioDevice();
			Rec.RecognizeAsync(RecognizeMode.Multiple);
		}

		private static void TriggerActivation(object sender, SpeechRecognizedEventArgs e)
		{
			Host.TriggerActivation();
			Console.WriteLine("Speech recognized: " + e.Result.Text);
		}
	}
}