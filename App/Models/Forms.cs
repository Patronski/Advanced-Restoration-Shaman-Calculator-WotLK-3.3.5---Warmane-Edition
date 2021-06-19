namespace App.Models
{
    public sealed class Forms
    {
        private Forms()
        {
        }

        public static Forms Instance { get; } = new Forms();

        public Calculator FormCalculator { get; set; }
        public StartScreen FormStartScreen { get; set; }
        public Info FormInfo { get; set; }
    }
}