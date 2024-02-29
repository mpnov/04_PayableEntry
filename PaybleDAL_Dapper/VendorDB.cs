using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Numerics;
using Dapper;

namespace PayableDAL
{
    public static class VendorDB
    {
        public static Vendor GetVendor(int vendorId)
        {
            Vendor vendor = null;
            string strSelect = "SELECT VendorID, Name, Address1, Address2, City, State, ZipCode, Phone, " +
                "ContactLName, ContactFName, DefaultTermsID, DefaultAccountNo " +
                "FROM Vendors " +
                "WHERE VendorID = @VendorID";

            using SqlConnection connection = new SqlConnection(PayableDB.ConnectionString);
            vendor = connection.Query<Vendor>(strSelect, new { VendorID = vendorId }).FirstOrDefault();

            return vendor;
        }

        public static List<Vendor> FindVendors(string name, string state)
        {
            List<Vendor> vendors = new List<Vendor>();
            string strSelect = "SELECT VendorID, Name, Address1, Address2, City, State, ZipCode, Phone, " +
                "ContactLName, ContactFName, DefaultTermsID, DefaultAccountNo " +
                "FROM Vendors " +
                "WHERE Name LIKE @Name AND State LIKE @State " +
                "ORDER BY Name";

            using SqlConnection connection = new SqlConnection(PayableDB.ConnectionString);
            vendors = connection.Query<Vendor>(strSelect, new {Name =name +  "%", State = state + "%"}).ToList();

            return vendors;
        }

        public static bool AddVendor(Vendor vendor)
        {
            string strInsert = "INSERT Vendors " +
                "(Name, Address1, Address2, City, State, ZipCode, Phone, ContactLName, ContactFName, DefaultTermsID, DefaultAccountNo) " +
                "VALUES " +
                "(@Name, @Address1, @Address2, @City, @State, @ZipCode, @Phone, @ContactLName, @ContactFName, @DefaultTermsID, @DefaultAccountNo);" +
                "SELECT SCOPE_IDENTITY();";

            using SqlConnection connection = new SqlConnection(PayableDB.ConnectionString);
            vendor.VendorID = connection.Query<int>(strInsert, vendor).FirstOrDefault();

            return (vendor.VendorID > 0);
        }

        public static bool UpdateVendor(Vendor oldVendor, Vendor vendor)
        {
            string strUpdate = "UPDATE Vendors SET " +
                "Name = @Name, " +
                "Address1 = @Address1, " +
                "Address2 = @Address2, " +
                "City = @City, " +
                "State = @State, " +
                "ZipCode = @ZipCode, " +
                "Phone = @Phone, " +
                "ContactLName = @ContactLName, " +
                "ContactFName = @ContactFName, " +
                "DefaultTermsID = @DefaultTermsID, " +
                "DefaultAccountNo = @DefaultAccountNo " +
                "WHERE " +
                "VendorID = @OldVendorID " +
                "AND Name = @OldName " +
                "AND Address1 = @OldAddress1 " +
                "AND Address2 = @OldAddress2 " +
                "AND City = @OldCity " +
                "AND State = @OldState " +
                "AND ZipCode = @OldZipCode " +
                "AND Phone = @OldPhone " +
                "AND ContactLName = @OldContactLName " +
                "AND ContactFName = @OldContactFName " +
                "AND DefaultTermsID = @OldDefaultTermsID " +
                "AND DefaultAccountNo = @OldDefaultAccountNo";

            using SqlConnection connection = new SqlConnection(PayableDB.ConnectionString);
            int count = connection.Execute(strUpdate, 
                new {
                    //new vendor
                    Name = vendor.Name, Address1 = vendor.Address1, Address2 = vendor.Address2, City = vendor.City, State = vendor.State,
                    ZipCode = vendor.ZipCode, Phone = vendor.Phone, ContactLName = vendor.ContactLName, ContactFName = vendor.ContactFName, 
                    DefaultTermsID = vendor.DefaultTermsID, DefaultAccountNo = vendor.DefaultAccountNo,
                    //oldVendor
                    OldVendorID = oldVendor.VendorID, OldName = oldVendor.Name, OldAddress1 = oldVendor.Address1, OldAddress2 = oldVendor.Address2, 
                    OldCity = oldVendor.City, OldState = oldVendor.State, OldZipCode = oldVendor.ZipCode, OldPhone = oldVendor.Phone, 
                    OldContactLName = oldVendor.ContactLName, OldContactFName = oldVendor.ContactFName, OldDefaultTermsID = oldVendor.DefaultTermsID, 
                    OldDefaultAccountNo = oldVendor.DefaultAccountNo 
                });

            return (count > 0);
        }
    }
}
