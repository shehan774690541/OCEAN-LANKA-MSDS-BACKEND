using ocl_msds.Helpers.Requests.Msds;
using ocl_msds.Helpers.Responces;

namespace ocl_msds.Services.Msds
{
    public interface IMsdsService
    {
        public BaseResponce ListByIthem(int i);

        public BaseResponce ListAll();

        public BaseResponce CreateMsds(CreateMSDSRequest r);

        public BaseResponce EditMsds(EditMSDSRequest r);

        public BaseResponce DeleteMsds(int id);
    }
}
