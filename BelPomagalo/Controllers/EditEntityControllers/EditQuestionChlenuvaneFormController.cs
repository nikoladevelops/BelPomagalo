using BelPomagalo.Models;
using BelPomagalo.Services;
using BelPomagalo.Utility;
using BelPomagalo.Views;
using BelPomagalo.Views.AddNewEntityForms;

namespace BelPomagalo.Controllers.EditEntityControllers
{
    internal class EditQuestionChlenuvaneFormController : EditEntityController
    {
        private QuestionChlenuvaneService _questionChlenuvaneService;
        private AddNewQuestionChlenuvaneForm _innerForm;
        public EditQuestionChlenuvaneFormController(EditForm form, AddNewQuestionChlenuvaneForm innerForm, QuestionChlenuvaneService questionChlenuvaneService) : base(form, innerForm)
        {
            _questionChlenuvaneService = questionChlenuvaneService;
            _innerForm = innerForm;
            LoadEntityListBox(0);
        }

        protected override async Task<bool> EditEntityData()
        {
            var questionChlenuvaneSentence = _entityListBox.SelectedItem.ToString();
            var questionChlenuvane = _questionChlenuvaneService.GetQuestionChlenuvane(questionChlenuvaneSentence);

            // Check if the selected questionChlenuvane sentence is not the same as the new questionChlenuvane sentence
            // in other words -> check if the user is trying to edit the questionChlenuvane sentence of the current questionChlenuvane
            // if he is trying to edit it to another sentence,
            // make sure that the new questionChlenuvane sentence doesn't already exist
            var newQuestionChlenuvaneSentence = _innerForm.SentenceTextBox.Text;
            if (questionChlenuvaneSentence != newQuestionChlenuvaneSentence && _questionChlenuvaneService.Exists(newQuestionChlenuvaneSentence))
            {
                MessageBox.Show("Вече съществува задача за членуване с такова изречение. Моля пробвайте друго.", "Грешка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var changesToApply = new QuestionChlenuvane()
            {
                Sentence = _innerForm.SentenceTextBox.Text,
                CorrectSentence = _innerForm.CorrectSentenceTextBox.Text,
                WrongAnswers = _innerForm.WrongAnswersTextBox.Text,
                CorrectAnswers = _innerForm.CorrectAnswersTextBox.Text,
                CountAnswers =
                _innerForm.CorrectAnswersTextBox.Text
                .Trim()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Count()
            };

            await _questionChlenuvaneService.EditQuestionChlenuvane(questionChlenuvane, changesToApply);

            LoadEntityListBox(_entityListBox.SelectedIndex);
            return true;
        }

        protected override void LoadEntityDataInAppropriateControls()
        {
            if (_entityListBox.SelectedIndex == -1)
            {
                return;
            }

            var questionChlenuvaneSentence = _entityListBox.SelectedItem.ToString();
            var questionChlenuvane = _questionChlenuvaneService.GetQuestionChlenuvane(questionChlenuvaneSentence);

            _innerForm.SentenceTextBox.Text = questionChlenuvane.Sentence;
            _innerForm.CorrectSentenceTextBox.Text = questionChlenuvane.CorrectSentence;
            _innerForm.WrongAnswersTextBox.Text = questionChlenuvane.WrongAnswers;
            _innerForm.CorrectAnswersTextBox.Text = questionChlenuvane.CorrectAnswers;
        }

        protected override void LoadEntityListBox(int selectedIndex = -1)
        {
            _entityListBox.Items.Clear();
            var allQuestionChlenuvaneSentences = _questionChlenuvaneService.GetAllQuestionChlenuvaneSentences();
            Helper.LoadListBoxData(_entityListBox, allQuestionChlenuvaneSentences, selectedIndex);
        }

        protected override bool ValidateEntityData()
        {
            if (_entityListBox.SelectedIndex == -1)
            {
                return false;
            }

            return Helper.CheckIfTextBoxesFilled(
                _innerForm.SentenceTextBox,
                _innerForm.CorrectSentenceTextBox,
                _innerForm.WrongAnswersTextBox,
                _innerForm.CorrectAnswersTextBox
                );
        }
    }
}
