﻿///////////////////////////////////////////////////////////////////////
// IFileService.cs - Interface for self-hosted file transfer service //
//                                                                   //
// author : Manjunath Panduranga                                    //
// source: Jim Fawcett,                                             //
// Jim Fawcett, CSE681 - Software Modeling and Analysis, Fall 2010   //
///////////////////////////////////////////////////////////////////////

using System;
using System.ServiceModel;

namespace FileTransferService
{
    [ServiceContract(Namespace = "FileTransferService")]
    public interface IFileService
    {
        [OperationContract]
        bool OpenFileForWrite(string name);

        [OperationContract]
        bool WriteFileBlock(byte[] block);

        [OperationContract]
        string messge();

        [OperationContract]
        bool CloseFile();
    }
}
