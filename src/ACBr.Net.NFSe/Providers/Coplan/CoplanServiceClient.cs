﻿// ***********************************************************************
// Assembly         : ACBr.Net.NFSe
// Author           : RFTD
// Created          : 05-16-2018
//
// Last Modified By : RFTD
// Last Modified On : 07-11-2018
// ***********************************************************************
// <copyright file="CoplanServiceClient.cs" company="ACBr.Net">
//		        		   The MIT License (MIT)
//	     		    Copyright (c) 2016 Grupo ACBr.Net
//
//	 Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the "Software"),
// to deal in the Software without restriction, including without limitation
// the rights to use, copy, modify, merge, publish, distribute, sublicense,
// and/or sell copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following conditions:
//	 The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//	 THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
// ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Net;
using System.Text;
using System.Xml.Linq;
using ACBr.Net.Core.Extensions;
using ACBr.Net.DFe.Core;

namespace ACBr.Net.NFSe.Providers
{
    internal sealed class CoplanServiceClient : NFSeSOAP11ServiceClient, IABRASF2Client
    {
        #region Fields

        private bool expect100Continue;

        #endregion Fields

        #region Constructors

        public CoplanServiceClient(ProviderCoplan provider, TipoUrl tipoUrl) : base(provider, tipoUrl)
        {
            expect100Continue = ServicePointManager.Expect100Continue;
            ServicePointManager.Expect100Continue = false;
        }

        ~CoplanServiceClient()
        {
            ServicePointManager.Expect100Continue = expect100Continue;
        }

        #endregion Constructors

        #region Methods

        public string RecepcionarLoteRps(string cabec, string msg)
        {
            var message = new StringBuilder();
            message.Append("<trib:nfse_web_service.RECEPCIONARLOTERPS>");
            message.Append("<trib:Recepcionarloterpsrequest>");
            message.Append("<trib:nfseCabecMsg>");
            message.AppendCData(cabec);
            message.Append("</trib:nfseCabecMsg>");
            message.Append("<trib:nfseDadosMsg>");
            message.AppendCData(msg);
            message.Append("</trib:nfseDadosMsg>");
            message.Append("</trib:Recepcionarloterpsrequest>");
            message.Append("</trib:nfse_web_service.RECEPCIONARLOTERPS>");

            return Execute("RECEPCIONARLOTERPS", message.ToString(), "nfse_web_service.RECEPCIONARLOTERPSResponse", "Recepcionarloterpsresponse");
        }

        public string RecepcionarLoteRpsSincrono(string cabec, string msg)
        {
            var message = new StringBuilder();
            message.Append("<trib:nfse_web_service.RECEPCIONARLOTERPSSINCRONO>");
            message.Append("<trib:Recepcionarloterpssincronorequest>");
            message.Append("<trib:nfseCabecMsg>");
            message.AppendCData(cabec);
            message.Append("</trib:nfseCabecMsg>");
            message.Append("<trib:nfseDadosMsg>");
            message.AppendCData(msg);
            message.Append("</trib:nfseDadosMsg>");
            message.Append("</trib:Recepcionarloterpssincronorequest>");
            message.Append("</trib:nfse_web_service.RECEPCIONARLOTERPSSINCRONO>");

            return Execute("RECEPCIONARLOTERPSSINCRONO", message.ToString(), "nfse_web_service.RECEPCIONARLOTERPSSINCRONOResponse", "Recepcionarloterpssincronoresponse");
        }

        public string ConsultarNFSePorRps(string cabec, string msg)
        {
            var message = new StringBuilder();
            message.Append("<trib:nfse_web_service.CONSULTARNFSEPORRPS>");
            message.Append("<trib:Consultarnfseporrpsrequest>");
            message.Append("<trib:nfseCabecMsg>");
            message.AppendCData(cabec);
            message.Append("</trib:nfseCabecMsg>");
            message.Append("<trib:nfseDadosMsg>");
            message.AppendCData(msg);
            message.Append("</trib:nfseDadosMsg>");
            message.Append("</trib:Consultarnfseporrpsrequest>");
            message.Append("</trib:nfse_web_service.CONSULTARNFSEPORRPS>");

            return Execute("CONSULTARNFSEPORRPS", message.ToString(), "nfse_web_service.CONSULTARNFSEPORRPSResponse", "Consultarnfseporrpsresponse");
        }

        public string ConsultarNFSeFaixa(string cabec, string msg)
        {
            var message = new StringBuilder();
            message.Append("<trib:nfse_web_service.CONSULTARNFSEFAIXA>");
            message.Append("<trib:Consultarnfseporfaixarequest>");
            message.Append("<trib:nfseCabecMsg>");
            message.AppendCData(cabec);
            message.Append("</trib:nfseCabecMsg>");
            message.Append("<trib:nfseDadosMsg>");
            message.AppendCData(msg);
            message.Append("</trib:nfseDadosMsg>");
            message.Append("</trib:Consultarnfseporfaixarequest>");
            message.Append("</trib:nfse_web_service.CONSULTARNFSEFAIXA>");

            return Execute("CONSULTARNFSEFAIXA", message.ToString(), "nfse_web_service.CONSULTARNFSEFAIXAResponse", "Consultarnfseporfaixaresponse");
        }

        public string ConsultarNFSeServicoTomado(string cabec, string msg)
        {
            var message = new StringBuilder();
            message.Append("<trib:nfse_web_service.CONSULTARNFSESERVICOTOMADO>");
            message.Append("<trib:Consultarnfseservicotomadorequest>");
            message.Append("<trib:nfseCabecMsg>");
            message.AppendCData(cabec);
            message.Append("</trib:nfseCabecMsg>");
            message.Append("<trib:nfseDadosMsg>");
            message.AppendCData(msg);
            message.Append("</trib:nfseDadosMsg>");
            message.Append("</trib:Consultarnfseservicotomadorequest>");
            message.Append("</trib:nfse_web_service.CONSULTARNFSESERVICOTOMADO>");

            return Execute("CONSULTARNFSESERVICOTOMADO", message.ToString(), "nfse_web_service.CONSULTARNFSESERVICOTOMADOResponse", "Consultarnfseservicotomadoresponse");
        }

        public string ConsultarNFSeServicoPrestado(string cabec, string msg)
        {
            var message = new StringBuilder();
            message.Append("<trib:nfse_web_service.CONSULTARNFSESERVICOPRESTADO>");
            message.Append("<trib:Consultarnfseservicoprestadorequest>");
            message.Append("<trib:nfseCabecMsg>");
            message.AppendCData(cabec);
            message.Append("</trib:nfseCabecMsg>");
            message.Append("<trib:nfseDadosMsg>");
            message.AppendCData(msg);
            message.Append("</trib:nfseDadosMsg>");
            message.Append("</trib:Consultarnfseservicoprestadorequest>");
            message.Append("</trib:nfse_web_service.CONSULTARNFSESERVICOPRESTADO>");

            return Execute("CONSULTARNFSESERVICOPRESTADO", message.ToString(), "nfse_web_service.CONSULTARNFSESERVICOPRESTADOResponse", "Consultarnfseservicoprestadoresponse");
        }

        public string ConsultarLoteRps(string cabec, string msg)
        {
            var message = new StringBuilder();
            message.Append("<trib:nfse_web_service.CONSULTARLOTERPS>");
            message.Append("<trib:Consultarloterpsrequest>");
            message.Append("<trib:nfseCabecMsg>");
            message.AppendCData(cabec);
            message.Append("</trib:nfseCabecMsg>");
            message.Append("<trib:nfseDadosMsg>");
            message.AppendCData(msg);
            message.Append("</trib:nfseDadosMsg>");
            message.Append("</trib:Consultarloterpsrequest>");
            message.Append("</trib:nfse_web_service.CONSULTARLOTERPS>");

            return Execute("CONSULTARLOTERPS", message.ToString(), "nfse_web_service.CONSULTARLOTERPSResponse", "Consultarloterpsresponse");
        }

        public string CancelarNFSe(string cabec, string msg)
        {
            var message = new StringBuilder();
            message.Append("<trib:nfse_web_service.CANCELARNFSE>");
            message.Append("<trib:Cancelarnfserequest>");
            message.Append("<trib:nfseCabecMsg>");
            message.AppendCData(cabec);
            message.Append("</trib:nfseCabecMsg>");
            message.Append("<trib:nfseDadosMsg>");
            message.AppendCData(msg);
            message.Append("</trib:nfseDadosMsg>");
            message.Append("</trib:Cancelarnfserequest>");
            message.Append("</trib:nfse_web_service.CANCELARNFSE>");

            return Execute("CANCELARNFSE", message.ToString(), "nfse_web_service.CANCELARNFSEResponse", "Cancelarnfseresponse");
        }

        public string SubstituirNFSe(string cabec, string msg)
        {
            var message = new StringBuilder();
            message.Append("<trib:nfse_web_service.SUBSTITUIRNFSE>");
            message.Append("<trib:Substituirnfserequest>");
            message.Append("<trib:nfseCabecMsg>");
            message.AppendCData(cabec);
            message.Append("</trib:nfseCabecMsg>");
            message.Append("<trib:nfseDadosMsg>");
            message.AppendCData(msg);
            message.Append("</trib:nfseDadosMsg>");
            message.Append("</trib:Substituirnfserequest>");
            message.Append("</trib:nfse_web_service.SUBSTITUIRNFSE>");

            return Execute("SUBSTITUIRNFSE", message.ToString(), "nfse_web_service.SUBSTITUIRNFSEResponse", "Substituirnfseresponse");
        }

        private string Execute(string action, string message, params string[] responseTag)
        {
            return Execute($"Tributarioaction/ANFSE_WEB_SERVICE.{action}", message, responseTag, "xmlns:trib=\"Tributario\"");
        }

        protected override string TratarRetorno(XDocument xmlDocument, string[] responseTag)
        {
            var element = xmlDocument.ElementAnyNs(responseTag[0])?.ElementAnyNs("Fault");
            if (element != null)
            {
                var exMessage = $"{element.ElementAnyNs("faultcode").GetValue<string>()} - {element.ElementAnyNs("faultstring").GetValue<string>()}";
                throw new ACBrDFeCommunicationException(exMessage);
            }

            return xmlDocument.ElementAnyNs(responseTag[0]).ElementAnyNs(responseTag[1]).ElementAnyNs("outputXML").Value;
        }

        #endregion Methods
    }
}