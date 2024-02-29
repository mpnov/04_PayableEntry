using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Numerics;

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
            using SqlCommand command = new SqlCommand(strSelect, connection);
            command.Parameters.AddWithValue("@VendorID", vendorId);
            connection.Open();
            using SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow & CommandBehavior.CloseConnection);
            if(reader.Read())
            {
                vendor = new Vendor();
                vendor.VendorID = (int)reader["VendorID"];
                vendor.Name = reader["Name"].ToString();
                vendor.Address1 = reader["Address1"].ToString();
                vendor.Address2 = reader["Address2"].ToString();
                vendor.City = reader["City"].ToString();
                vendor.State = reader["State"].ToString();
                vendor.ZipCode = reader["ZipCode"].ToString();
                vendor.Phone = reader["Phone"].ToString();
                vendor.ContactLName = reader["ContactLName"].ToString();
                vendor.ContactFName = reader["ContactFName"].ToString();
                vendor.DefaultTermsID = (int)reader["DefaultTermsID"];
                vendor.DefaultAccountNo = (int)reader["DefaultAccountNo"];
            }

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
            using SqlCommand command = new SqlCommand(strSelect, connection);
            command.Parameters.AddWithValue("@Name", name + "%");
            command.Parameters.AddWithValue("@State", state + "%");
            connection.Open();
            using SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                Vendor vendor = new Vendor();
                vendor.VendorID = (int)reader["VendorID"];
                vendor.Name = reader["Name"].ToString();
                vendor.Address1 = reader["Address1"].ToString();
                vendor.Address2 = reader["Address2"].ToString();
                vendor.City = reader["City"].ToString();
                vendor.State = reader["State"].ToString();
                vendor.ZipCode = reader["ZipCode"].ToString();
                vendor.Phone = reader["Phone"].ToString();
                vendor.ContactLName = reader["ContactLName"].ToString();
                vendor.ContactFName = reader["ContactFName"].ToString();
                vendor.DefaultTermsID = (int)reader["DefaultTermsID"];
                vendor.DefaultAccountNo = (int)reader["DefaultAccountNo"];
                vendors.Add(vendor);
            }

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
            using SqlCommand command = new SqlCommand(strInsert, connection);
            command.Parameters.AddWithValue("@Name", vendor.Name);
            command.Parameters.AddWithValue("@Address1", vendor.Address1);
            command.Parameters.AddWithValue("@Address2", vendor.Address2 == string.Empty ? DBNull.Value : vendor.Address2);
            command.Parameters.AddWithValue("@City", vendor.City);
            command.Parameters.AddWithValue("@State", vendor.State);
            command.Parameters.AddWithValue("@ZipCode", vendor.ZipCode);
            command.Parameters.AddWithValue("@Phone", vendor.Phone == string.Empty ? DBNull.Value : vendor.Phone);
            command.Parameters.AddWithValue("@ContactLName", vendor.ContactLName == string.Empty ? DBNull.Value : vendor.ContactLName);
            command.Parameters.AddWithValue("@ContactFName", vendor.ContactFName == string.Empty ? DBNull.Value : vendor.ContactFName);
            command.Parameters.AddWithValue("@DefaultTermsID", vendor.DefaultTermsID);
            command.Parameters.AddWithValue("@DefaultAccountNo", vendor.DefaultAccountNo);
            connection.Open();
            vendor.VendorID = Convert.ToInt32(command.ExecuteScalar());

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
            using SqlCommand command = new SqlCommand(strUpdate, connection);
            //new vendor
            command.Parameters.AddWithValue("@Name", vendor.Name);
            command.Parameters.AddWithValue("@Address1", vendor.Address1);
            command.Parameters.AddWithValue("@Address2", vendor.Address2 == string.Empty ? DBNull.Value : vendor.Address2);
            command.Parameters.AddWithValue("@City", vendor.City);
            command.Parameters.AddWithValue("@State", vendor.State);
            command.Parameters.AddWithValue("@ZipCode", vendor.ZipCode);
            command.Parameters.AddWithValue("@Phone", vendor.Phone == string.Empty ? DBNull.Value : vendor.Phone);
            command.Parameters.AddWithValue("@ContactLName", vendor.ContactLName == string.Empty ? DBNull.Value : vendor.ContactLName);
            command.Parameters.AddWithValue("@ContactFName", vendor.ContactFName == string.Empty ? DBNull.Value : vendor.ContactFName);
            command.Parameters.AddWithValue("@DefaultTermsID", vendor.DefaultTermsID);
            command.Parameters.AddWithValue("@DefaultAccountNo", vendor.DefaultAccountNo);
            //old vendor
            command.Parameters.AddWithValue("@OldVendorID", oldVendor.VendorID);
            command.Parameters.AddWithValue("@OldName", oldVendor.Name);
            command.Parameters.AddWithValue("@OldAddress1", oldVendor.Address1);
            command.Parameters.AddWithValue("@OldAddress2", oldVendor.Address2 == string.Empty ? DBNull.Value : oldVendor.Address2);
            command.Parameters.AddWithValue("@OldCity", oldVendor.City);
            command.Parameters.AddWithValue("@OldState", oldVendor.State);
            command.Parameters.AddWithValue("@OldZipCode", oldVendor.ZipCode);
            command.Parameters.AddWithValue("@OldPhone", oldVendor.Phone == string.Empty ? DBNull.Value : oldVendor.Phone);
            command.Parameters.AddWithValue("@OldContactLName", oldVendor.ContactLName == string.Empty ? DBNull.Value : oldVendor.ContactLName);
            command.Parameters.AddWithValue("@OldContactFName", oldVendor.ContactFName == string.Empty ? DBNull.Value : oldVendor.ContactFName);
            command.Parameters.AddWithValue("@OldDefaultTermsID", oldVendor.DefaultTermsID);
            command.Parameters.AddWithValue("@OldDefaultAccountNo", oldVendor.DefaultAccountNo);
            connection.Open();
            int count = command.ExecuteNonQuery();
            return (count > 0);
        }
    }
}
