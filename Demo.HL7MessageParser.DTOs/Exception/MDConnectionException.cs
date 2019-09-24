/*
************************************************************************************************
*      
*                Title:    MedDispenseException
*          Description:    It is used to define base exception class
*            Copyright:    Copyright(c) InterMetro Industries Corporation All rights reserved
*              Company:    InterMetro Industries
*              @author:    John.Tian
*           Creat Date:    7/24/2013
*        Last Modifier:    
*     Last Modify Date:    
*             @version:    1.00.00
* 
************************************************************************************************
*/
#region Update History
/*
------------------------------------------------------------------------------------------------
 Modification history:                                              						               
 date        Author         Description                          		    		         
 --------    ------------   ---------------------------------------------------------
 08/07/2012                1.
                           2.
------------------------------------------------------------------------------------------------
*/
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ServiceModel;
using System.Net.Sockets;
using System.Runtime.Remoting;

namespace Demo.HL7MessageParser.DTOs
{
    //CommunicationException
    //RemotingException
    [Serializable]
    public class MDConnectionException:SystemException
    {
        public MDConnectionException()
        {
        }

        public MDConnectionException (string message):base(message)
        {
        }

        public MDConnectionException(string message, Exception innerException):base(message ,innerException)
        {
        }
    }
}
