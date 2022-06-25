using BelPomagalo.Views;
using System.Diagnostics;

namespace BelPomagalo.Controllers
{
    internal class GamesFormController : Controller<GamesForm>
    {
        public GamesFormController(GamesForm form) : base(form)
        {
            _form.GuessGenreButton.Click += (x,y)=> OpenGame("GuessGenre.exe");
            _form.GuessAuthorButton.Click += (x,y)=> OpenGame("GuessAuthor.exe");
            _form.GuessThemesButton.Click += (x,y)=> OpenGame("GuessThemes.exe");
            _form.GuessCompositionButton.Click += (x,y)=> OpenGame("GuessComposition.exe");
            _form.RemindPublishedWorksButton.Click += (x,y)=> OpenGame("RemindPublishedWork.exe");
            _form.ChlenuvaiButton.Click += (x,y)=> OpenGame("QuestionChlenuvane.exe");
            _form.RemindGrammarRulesButton.Click += (x,y)=> OpenGame("RemindGrammarRules.exe");
            _form.RemindWritingRulesButton.Click += (x,y)=> OpenGame("RemindWritingRules.exe");
            _form.RemindPunctuationRulesButton.Click += (x,y)=> OpenGame("RemindPunctuationRules.exe");
        }

        public void OpenGame(string gameName) 
        {
            try
            {
                Process.Start($"{gameName}");
            }
            catch (Exception)
            {
                MessageBox.Show("Настъпи грешка моля уверете се че сте спазили инструкциите за сваляне на това приложение от GitHub (https://github.com/nikoladevelops/BelPomagalo).", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
