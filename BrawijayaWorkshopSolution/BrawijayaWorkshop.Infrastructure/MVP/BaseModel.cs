using System;

namespace BrawijayaWorkshop.Infrastructure.MVP
{
    public abstract class BaseModel
    {
        public virtual bool Validate(params object[] parameters)
        {
            throw new NotImplementedException();
        }
    }
}
