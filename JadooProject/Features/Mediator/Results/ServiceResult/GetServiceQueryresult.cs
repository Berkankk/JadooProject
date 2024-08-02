namespace JadooProject.Features.Mediator.Results.ServiceResult
{
    public class GetServiceQueryresult
    {
        //Geriye edğer döndürenleri results klasöründe ve başına get getirerk yazıyoruz
        public int ServiceID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }
}
