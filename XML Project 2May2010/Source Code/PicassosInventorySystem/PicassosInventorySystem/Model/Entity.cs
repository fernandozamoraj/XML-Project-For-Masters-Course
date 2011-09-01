using PicassosInventorySystem.Utility;

namespace PicassosInventorySystem.Model
{
    public abstract class Entity : IIdentifiable
    {
        protected string _Id;

        public abstract string GetPrefix();
        public string Comments { get; set; }

        public string Id
        {
            get
            {
                if(string.IsNullOrEmpty( _Id ))
                {
                    IdManager manager = IdManager.GetIdManager();

                    _Id = manager.GetNewId(this, GetPrefix());  
                }

                return _Id;
            } 
            set
            {
                IdManager manager = IdManager.GetIdManager();

                manager.RegisterId(this, value);

                _Id = value;
            }
        }

        public bool IsNull()
        {
            return string.IsNullOrEmpty(_Id);
        }

        public virtual void SetNewId()
        {
            IdManager manager = IdManager.GetIdManager();

            Id = manager.GetNewId(this, GetPrefix());
        }

        public void RegisterId()
        {
            IdManager manager = IdManager.GetIdManager();

            manager.RegisterId(this, _Id);
        }
    }
}
