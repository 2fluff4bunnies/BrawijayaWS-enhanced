using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class SparepartDetailListModel : BaseModel
    {
        private ISparepartRepository _sparepartRepository;
        private ISparepartDetailRepository _sparepartDetailRepository;
        private IUnitOfWork _unitOfWork;

        public SparepartDetailListModel(ISparepartRepository sparepartRepository,
            ISparepartDetailRepository sparepartDetailRepository, IUnitOfWork unitOfWork)
        {
            _sparepartRepository = sparepartRepository;
            _sparepartDetailRepository = sparepartDetailRepository;
            _unitOfWork = unitOfWork;
        }

        public List<SparepartDetail> SearchSparepart(int sparepartId, DbConstant.SparepartDetailDataStatus status)
        {
            List<SparepartDetail> result = _sparepartDetailRepository.GetMany(
                spd => spd.SparepartId == sparepartId && spd.Status == (int)status).ToList();

            return result;
        }
    }
}
