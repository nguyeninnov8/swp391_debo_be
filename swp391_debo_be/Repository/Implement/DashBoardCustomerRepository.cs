﻿using swp391_debo_be.Dao.Implement;
using swp391_debo_be.Dao.Interface;
using swp391_debo_be.Dto.Implement;
using swp391_debo_be.Repository.Interface;

namespace swp391_debo_be.Repository.Implement
{
    public class DashBoardCustomerRepository : IDashBoardCustomerRepository
    {
        private readonly IDashBoardCustomerDao _dashBoardDao;

        public DashBoardCustomerRepository()
        {
            _dashBoardDao = new DashBoardCustomerDao();
        }

        public DashBoardCustomerRepository(IDashBoardCustomerDao dashBoardDao) 
        {
            _dashBoardDao = dashBoardDao;
        }

        public Task<List<object>> CountAppointmentsByTreatment()
        {
            return _dashBoardDao.CountAppointmentsByTreatment();
        }

        public Task<List<object>> CountAppointmentsByTreatmentCategory()
        {
            return _dashBoardDao.CountAppointmentsByTreatmentCategory();
        }

        public Task<List<DashboardCustomerDto>> ViewAppointmentState(Guid id)
        {
            return _dashBoardDao.ViewAppointmentState(id);
        }

        public Task<List<object>> ViewAppointmentStateByDentist(Guid id)
        {
            return _dashBoardDao.ViewAppointmentStateByDentist(id);
        }

        public Task<List<object>> ViewMonthlyRevenueForCurrentYear()
        {
            return _dashBoardDao.ViewMonthlyRevenueForCurrentYear();
        }

        public Task<List<object>> ViewTotalAppointmentEachMonthsByDentist(Guid id)
        {
            return _dashBoardDao.ViewTotalAppointmentEachMonthsByDentist(id);
        }

        public Task<List<DashboardCustomerDto>> ViewTotalPaidAmountOfCustomer(Guid id)
        {
            return _dashBoardDao.ViewTotalPaidAmountOfCustomer(id);
        }

        public Task<DashboardAdminDto> ViewTotalRevenue()
        {
            return _dashBoardDao.ViewTotalRevenue();
        }
    }
}
