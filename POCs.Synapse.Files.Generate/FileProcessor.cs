using POCs.Synapse.Entities;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;

namespace POCs.Synapse.Files.Generate;
internal static class FileProcessor
{
    internal static readonly Lazy<XmlSerializer> _invoiceSerializer = new(() => new XmlSerializer(typeof(Invoice)));
    internal static void SaveTaxpayers(List<Taxpayer> taxpayers, string fileName)
    {
        var json = JsonSerializer.Serialize(taxpayers);
        using var file = File.OpenWrite(fileName);
        file.Write(Encoding.UTF8.GetBytes(json));
        file.Flush();
    }

    internal static List<Taxpayer> OpenTaxpayers(string fileName)
    {
        using var file = File.OpenText(fileName);
        var json = file.ReadToEnd();
        var taxpayers = JsonSerializer.Deserialize<List<Taxpayer>>(json);
        return taxpayers!;
    }

    internal static void SaveInvoice(Invoice invoice, string folder)
    {
        var path = Path.Combine(folder, $"{invoice.Id}.xml");
        using var file = File.OpenWrite(path);
        _invoiceSerializer.Value.Serialize(file, invoice);
    }

    internal static byte[] OpenInvoice()
}
