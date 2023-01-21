using AngleSharp.Html.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserTgBot.Core
{
    class ParcerWorker<T> where T : class
    {
        IParcer<T> parcer;
        IParcerSettings settings;
        HtmlLoader loader;
        private bool isActive;

        #region Properties
        public IParcer<T> Parcer
        {
            get { return parcer; }
            set { parcer = value; }
        }
        public IParcerSettings Settings
        {
            get { return settings; }
            set 
            { 
                settings = value;
                loader = new HtmlLoader(value);
            }
        }
        public bool IsActive
        {
            get { return isActive; }
        }
        #endregion

        public event Action<object, T> OnNewData;
        public event Action<object> OnCompleted;

        public ParcerWorker(IParcer<T> parcer)
        {
            this.parcer = parcer;
        }

        public ParcerWorker(IParcer<T> parcer, IParcerSettings parcerSettings) : this(parcer)
        {
            settings = parcerSettings;
        }

        public void Start()
        {
            isActive = true;
            Worker();
        }

        public void Abort()
        {
            isActive = false;

        }

        private async void Worker()
        {
            for (int i = settings.StartPoint; i <= settings.EndPoint; i++)
            {
                if (!isActive)
                {
                    OnCompleted?.Invoke(this);
                    return;
                }
                var source = await loader.GetSourceByInstituteNumber(i);
                var domParcer = new HtmlParser();

                var document = await domParcer.ParseDocumentAsync(source);

                var result = parcer.Parce(document);

                OnNewData?.Invoke(this, result);
            }
            OnCompleted?.Invoke(this);
            isActive = false;
        }

    }
}
