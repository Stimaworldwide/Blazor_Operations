using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor_Operations.Data;

namespace Blazor_Operations.Services
{
    public class OperationsServices
    {
        protected readonly ApplicationDbContext _dbContext;

        public OperationsServices(ApplicationDbContext _db)
        {
            _dbContext = _db;
        }
        public List<Operationsclass> GetOperations()
        {
            return _dbContext.OperationsTable.ToList();
        }
        public Operationsclass GetOperationsdetails(int operationsID) 
        {
            Operationsclass editobj = new Operationsclass();
            return _dbContext.OperationsTable.FirstOrDefault(u=>u.OperationID == operationsID);
            //lamda
        }

        public bool UpdateOperations(Operationsclass Updatedetails) 
        {
            var GetOperations = _dbContext.OperationsTable.FirstOrDefault(u => u.OperationID == Updatedetails.OperationID);
            if (GetOperations != null)
            {
                GetOperations.Name = Updatedetails.Name;
                GetOperations.OrderInWhichToPerform = Updatedetails.OrderInWhichToPerform;
                GetOperations.ImageData = Updatedetails.ImageData;
                GetOperations.Device = Updatedetails.Device;
                _dbContext.SaveChanges();
            }
            else 
            {
                return false;
            }
            return true;
        }

        public bool AddOperation(Operationsclass oppadd)
        {
            _dbContext.OperationsTable.Add(oppadd);
            _dbContext.SaveChanges();
            return true;
        }


        public bool Delete(Operationsclass Deletedetails)
        {
            var GetOperations = _dbContext.OperationsTable.FirstOrDefault(u => u.OperationID == Deletedetails.OperationID);
            if (GetOperations != null)
            {
                _dbContext.Remove(GetOperations);
                _dbContext.SaveChanges();
            }
            else
            {
                return false;
            }
            return true;
        }

    }
}
