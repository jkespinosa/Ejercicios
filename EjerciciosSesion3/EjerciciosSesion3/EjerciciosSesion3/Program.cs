// See https://aka.ms/new-console-template for more information
Main();

static void Main(){
    Customer cus = new Customer("Jessica Espinosa","7777-7777", "Direccion de prueba", "test@test.com", false);

    Console.WriteLine(cus);
    Console.WriteLine("Nombre completo: {0} Telefono: {1} Direccion:{2}", cus.FullName, cus.Phone, cus.Address);
    Console.WriteLine("Correo: {0}", cus.Email);
    Console.WriteLine("Es nuevo cliente: {0}", (cus.IsNewCustomer == true? "Nuevo cliente": "Cliente existente") );

}

public struct Customer
{
    public Customer(string fullName, string phone, string address, string email, bool isNewCustomer)
    {
        FullName = fullName;
        Phone = phone;
        Address = address;
        Email = email;
        IsNewCustomer = isNewCustomer;
    }

    public string FullName { get; }
    public string Phone { get; }
    public string Address { get; }
    public string Email { get; }
    public bool IsNewCustomer { get; }

    public override string ToString() => $"({FullName}, {Phone}, {Address}, {Email}, {IsNewCustomer})";
}
