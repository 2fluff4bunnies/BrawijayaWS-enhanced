﻿using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class WheelEditorModel : AppBaseModel
    {
        private IWheelRepository _wheelRepository;
        private IReferenceRepository _referenceRepository;
        private ISparepartRepository _sparepartRepository;
        private IUnitOfWork _unitOfWork;

        public WheelEditorModel(IWheelRepository WheelRepository, IReferenceRepository referenceRepository,
           ISparepartRepository sparepartRepository,IUnitOfWork unitOfWork)
            : base()
        {
            _wheelRepository = WheelRepository;
            _referenceRepository = referenceRepository;
            _sparepartRepository = sparepartRepository;
            _unitOfWork = unitOfWork;
        }

        public List<SparepartViewModel> GetSparepartLookupList()
        {
            List<Sparepart> result = _sparepartRepository.GetMany(sp => sp.Status == (int)DbConstant.DefaultDataStatus.Active).ToList();
            List<SparepartViewModel> mappedResult = new List<SparepartViewModel>();

            return Map(result, mappedResult);
        }

        public void InsertWheel(WheelViewModel wheel, int userId)
        {
            DateTime serverTime = DateTime.Now;
            wheel.CreateDate = serverTime;
            wheel.CreateUserId = userId;
            wheel.Status = (int)DbConstant.DefaultDataStatus.Active;
            Wheel entity = new Wheel();
            Map(wheel, entity);
            _wheelRepository.Add(entity);
            _unitOfWork.SaveChanges();
        }

        public void UpdateWheel(WheelViewModel wheel, int userId)
        {
            DateTime serverTime = DateTime.Now;
            wheel.ModifyDate = serverTime;
            wheel.ModifyUserId = userId;
            Wheel entity = _wheelRepository.GetById(wheel.Id);
            Map(wheel, entity);
            _wheelRepository.Update(entity);
            _unitOfWork.SaveChanges();
        }
    }
}
