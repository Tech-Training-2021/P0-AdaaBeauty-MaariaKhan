using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Xunit;

namespace BeautyStore
{
    class Testing : Adaa
    {
        //1
        public void TestRegisterEmail()
        {
            //Arrange
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            match = regex.Match(email);
            bool expected_regex = true;

            //Act
            bool actual_regex = match.Success;

            //Assert
            Assert.Equal(expected_regex, actual_regex);
            

        }
        //2
        public void TestRegisterEmailNull()
        {
            //Arrange
            bool expected_result = false;
            //Act
          
            bool actual_result = string.IsNullOrEmpty(email);

            //Assert
            Assert.Equal(expected_result, actual_result);


        }
        //3
        public void TestRegisterPasswordLength()
        {
            //Arrange
            bool expected_length = true;

            //Act
            int pwd_length = pass.Length;
            bool actual_length = false;
            if((pwd_length>7) && (pwd_length < 33))
            {
                actual_length = true;
                
            }

            //Assert
            Assert.Equal(expected_length, actual_length);
          

        }
        //4
        public void TestRegisterPasswordNull()
        {
            //Arrange
            bool expected_result=false;

            //Act
            bool actual_result = string.IsNullOrEmpty(pass);

            //Assert
            Assert.Equal(expected_result,actual_result);


        }
        //5
        public void TestLoginUsernameNull()
        {
            //Arrange
            bool expected_result = false;

            //Act
            bool actual_result = string.IsNullOrEmpty(usrname);

            //Assert
            Assert.Equal(expected_result, actual_result);


        }
        //6
        public void TestLoginUsernameLength()
        {
            //Arrange
            bool expected_length = true;

            //Act
            int usrname_length = usrname.Length;
            bool actual_length = false;
            if ((usrname_length>0) &&(usrname_length<26))
            {
                actual_length = true;

            }

            //Assert
            Assert.Equal(expected_length, actual_length);


        }
        //7
        public void TestLoginpasswordNull()
        {
            //Arrange
            bool expected_result = false;

            //Act
            bool actual_result = string.IsNullOrEmpty(pass);

            //Assert
            Assert.Equal(expected_result, actual_result);

        }
        //8
        public void TestAdmin()
        {
            // Arrange
            string admin_name = "admin";
            string admin_pwd = "admin";

            // Act
            string my_admin_name = ad_usr;
            string my_admin_pwd = ad_pd;

            // Assert
            Assert.Equal(admin_name, my_admin_name);
            Assert.Equal(admin_pwd, my_admin_pwd);


        }

    }
}
    
