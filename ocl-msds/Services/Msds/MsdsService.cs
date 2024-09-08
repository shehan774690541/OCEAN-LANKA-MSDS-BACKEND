using ocl_msds.Helpers.Requests.Msds;
using ocl_msds.Helpers.Responces;

namespace ocl_msds.Services.Msds
{
    public class MsdsService : IMsdsService
    {
        public BaseResponce CreateMsds(CreateMSDSRequest r)
        {
            BaseResponce responce = new BaseResponce();

            try
            {
                responce = new BaseResponce()
                {
                    data =$"name : {r.name} \ncheck : {r.check} \ndepartment : {r.department} \nfile : {r.file} ",
                    status_code = 200,
                };
            }
            catch (Exception ex)
            {
                responce = new BaseResponce()
                {
                    data = $"Create MSDS Error : {ex.Message}",
                    status_code = 500,
                };
            }

            return responce;
        }

        public BaseResponce DeleteMsds(int id)
        {
            BaseResponce responce = new BaseResponce();

            try
            {
                responce = new BaseResponce()
                {
                    data = $"Delete MSDS {id}",
                    status_code = 200,
                };
            }
            catch (Exception ex)
            {
                responce = new BaseResponce()
                {
                    data = $"Delete MSDS Error : {ex.Message}",
                    status_code = 500,
                };
            }

            return responce;
        }

        public BaseResponce EditMsds(EditMSDSRequest r)
        {
            BaseResponce responce = new BaseResponce();

            try
            {
                responce = new BaseResponce()
                {
                    data = $"id: {r.Id} \nname : {r.name} \ncheck : {r.check} \ndepartment : {r.department} \nfile : {r.file} ",
                    status_code = 200,
                };
            }
            catch (Exception ex)
            {
                responce = new BaseResponce()
                {
                    data = $"Edit MSDS Error : {ex.Message}",
                    status_code = 500,
                };
            }

            return responce;
        }

        public BaseResponce ListAll()
        {
            BaseResponce responce = new BaseResponce();

            try
            {
                responce = new BaseResponce()
                {
                    data = "List All MSDS",
                    status_code = 200,
                };
            }
            catch (Exception ex)
            {
                responce = new BaseResponce()
                {
                    data = $"List All MSDS Error : {ex.Message}",
                    status_code = 500,
                };
            }

            return responce;
        }

        public BaseResponce ListByIthem(int i)
        {
            BaseResponce responce = new BaseResponce();

            try
            {
                responce = new BaseResponce()
                {
                    data = $"List By Ithem MSDS: {i}",
                    status_code = 200,
                };
            }
            catch (Exception ex)
            {
                responce = new BaseResponce()
                {
                    data = $"List By Ithem MSDS Error : {ex.Message}",
                    status_code = 500,
                };
            }

            return responce;
        }
    }
}
