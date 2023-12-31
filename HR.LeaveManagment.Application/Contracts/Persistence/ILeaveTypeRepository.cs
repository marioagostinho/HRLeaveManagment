﻿using HRLeaveManagementDomain;

namespace HR.LeaveManagment.Application.Contracts.Persistence
{
    public interface ILeaveTypeRepository : IGenericRepository<LeaveType>
    {
        Task<bool> IsLeaveTypeUnique(string name);
    }
}
