namespace ComputerCompany;

public class Program
{
    public static void Main(string[] args)
    {
        MSIManufacturer msiManufacturer = new MSIManufacturer();
        msiManufacturer.AssembleGpu();

        AsusManufacturer asusManufacturer = new AsusManufacturer();
        asusManufacturer.AssembleGpu();
    }
}