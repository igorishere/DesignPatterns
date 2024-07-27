namespace DesignPatterns.Behavioral.Template.WithDesignPattern.Report
{
    public abstract class BaseReport
    {
        public void Show()
        {
            this.ShowHeader();
            this.ShowContent();
            this.ShowFooter();
        }

        protected abstract void ShowHeader();
        protected abstract void ShowContent();
        protected abstract void ShowFooter();
    }
};