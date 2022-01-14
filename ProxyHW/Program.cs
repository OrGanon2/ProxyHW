namespace ProxyHW
{
    class program
    {
        public void Main(string[]Arg)
        {
            InteriorOffice interiorOffice = new InteriorOffice();
            ServiceMachine serviceMachine = new ServiceMachine(interiorOffice);

            serviceMachine.PassportRenewal();
            serviceMachine.ClientInfo();
            serviceMachine.ChangeAdress();
            serviceMachine.changePassword();
            
        }
    }
}