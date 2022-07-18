//simple test

//Test 

namespace SimpleTest
{
    public class SimpleTextParser
    {
        private readonly ILogger logger;

        public SimpleTextParser(ILogger logger)
        {
            this.logger = logger;
        }

        public string SortStringParagraph(string inputString)
        {
            if (string.IsNullOrEmpty(inputString))
            {
                throw new ArgumentNullException(nameof(inputString));
            }

            logger.Log("start SortStringParagraph");

            inputString = RemovePunchuation(inputString).Trim();

            //algorithm
            var words = inputString.Split(' ').ToList<string>();

            words.Sort((w1, w2) =>
            {
                int result = string.Compare(w1, w2, StringComparison.OrdinalIgnoreCase);
                return result == 0 ? string.Compare(w1, w2, StringComparison.Ordinal) : result;
            });

            string outputString = string.Join(' ', words).Trim();

            logger.Log("end SortStringParagraph");

            return outputString;
        }

        #region Private Methods

        private string RemovePunchuation(string paragraph)
        {
            paragraph = paragraph.Replace('.', ' ');
            paragraph = paragraph.Replace(',', ' ');
            paragraph = paragraph.Replace(';', ' ');
            return paragraph;
        }

        #endregion
    }
}
