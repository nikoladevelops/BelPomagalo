using BelPomagalo.Models;
using BelPomagalo.Services;
using BelPomagalo.Utility;
using BelPomagalo.Views.AddNewEntityForms;

namespace BelPomagalo.Controllers.AddNewEntityControllers
{
    internal class AddNewQuestionChlenuvaneFormController : AddEntityController<AddNewQuestionChlenuvaneForm>
    {
        private QuestionChlenuvaneService _questionChlenuvaneService;
        public AddNewQuestionChlenuvaneFormController(AddNewQuestionChlenuvaneForm form, QuestionChlenuvaneService questionChlenuvaneService) : base(form)
        {
            _questionChlenuvaneService = questionChlenuvaneService;
        }

        protected override async Task<bool> AddNewEntity()
        {
            // Check if a questionChlenuvane with this sentence already exists
            // if it does, show an error message
            if (_questionChlenuvaneService.Exists(_form.SentenceTextBox.Text))
            {
                MessageBox.Show("Вече съществува задача за членуване с такова изречение.", "Грешка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var questionChlenuvane = new QuestionChlenuvane()
            {
                Sentence = _form.SentenceTextBox.Text,
                CorrectSentence = _form.CorrectSentenceTextBox.Text,
                CorrectAnswers = _form.CorrectAnswersTextBox.Text,
                WrongAnswers = _form.WrongAnswersTextBox.Text
            };

            await _questionChlenuvaneService.AddQuestionChlenuvane(questionChlenuvane);
            return true;
        }

        protected override bool ValidateEntityData()
        {
            return Helper.CheckIfTextBoxesFilled(
                _form.SentenceTextBox,
                _form.CorrectSentenceTextBox,
                _form.CorrectAnswersTextBox,
                _form.WrongAnswersTextBox);
        }
    }
}
