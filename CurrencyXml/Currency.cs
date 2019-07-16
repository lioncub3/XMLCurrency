using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CurrencyXml
{
    [XmlRoot(ElementName = "title")]
    public class Title
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }

    [XmlRoot(ElementName = "branch")]
    public class Branch
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }

    [XmlRoot(ElementName = "region")]
    public class Region
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "title")]
        public string Title { get; set; }
    }

    [XmlRoot(ElementName = "city")]
    public class City
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "title")]
        public string Title { get; set; }
    }

    [XmlRoot(ElementName = "phone")]
    public class Phone
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }

    [XmlRoot(ElementName = "address")]
    public class Address
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }

    [XmlRoot(ElementName = "link")]
    public class Link
    {
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "href")]
        public string Href { get; set; }
    }

    [XmlRoot(ElementName = "c")]
    public class C
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "br")]
        public string Br { get; set; }
        [XmlAttribute(AttributeName = "ar")]
        public string Ar { get; set; }
        [XmlAttribute(AttributeName = "title")]
        public string Title { get; set; }
    }

    [XmlRoot(ElementName = "currencies")]
    public class Currencies
    {
        [XmlElement(ElementName = "c")]
        public List<C> C { get; set; }
    }

    [XmlRoot(ElementName = "organization")]
    public class Organization
    {
        [XmlElement(ElementName = "title")]
        public Title Title { get; set; }
        [XmlElement(ElementName = "branch")]
        public Branch Branch { get; set; }
        [XmlElement(ElementName = "region")]
        public Region Region { get; set; }
        [XmlElement(ElementName = "city")]
        public City City { get; set; }
        [XmlElement(ElementName = "phone")]
        public Phone Phone { get; set; }
        [XmlElement(ElementName = "address")]
        public Address Address { get; set; }
        [XmlElement(ElementName = "link")]
        public Link Link { get; set; }
        [XmlElement(ElementName = "currencies")]
        public Currencies Currencies { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "oldid")]
        public string Oldid { get; set; }
        [XmlAttribute(AttributeName = "org_type")]
        public string Org_type { get; set; }
    }

    [XmlRoot(ElementName = "organizations")]
    public class Organizations
    {
        [XmlElement(ElementName = "organization")]
        public List<Organization> Organization { get; set; }
    }

    [XmlRoot(ElementName = "org_type")]
    public class Org_type
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "title")]
        public string Title { get; set; }
    }

    [XmlRoot(ElementName = "org_types")]
    public class Org_types
    {
        [XmlElement(ElementName = "org_type")]
        public List<Org_type> Org_type { get; set; }
    }

    [XmlRoot(ElementName = "regions")]
    public class Regions
    {
        [XmlElement(ElementName = "region")]
        public List<Region> Region { get; set; }
    }

    [XmlRoot(ElementName = "cities")]
    public class Cities
    {
        [XmlElement(ElementName = "city")]
        public List<City> City { get; set; }
    }

    [XmlRoot(ElementName = "source")]
    public class Source
    {
        [XmlElement(ElementName = "organizations")]
        public Organizations Organizations { get; set; }
        [XmlElement(ElementName = "org_types")]
        public Org_types Org_types { get; set; }
        [XmlElement(ElementName = "currencies")]
        public Currencies Currencies { get; set; }
        [XmlElement(ElementName = "regions")]
        public Regions Regions { get; set; }
        [XmlElement(ElementName = "cities")]
        public Cities Cities { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "date")]
        public string Date { get; set; }
    }

}
