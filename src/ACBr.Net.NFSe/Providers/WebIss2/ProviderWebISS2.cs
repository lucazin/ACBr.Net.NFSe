// ***********************************************************************
// Assembly         : ACBr.Net.NFSe
// Author           : RFTD
// Created          : 12-24-2017
//
// Last Modified By : RFTD
// Last Modified On : 12-24-2017
// ***********************************************************************
// <copyright file="ProviderWebIss2.cs" company="ACBr.Net">
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

using ACBr.Net.NFSe.Configuracao;

namespace ACBr.Net.NFSe.Providers.WebISS2
{
    // ReSharper disable once InconsistentNaming
    internal sealed class ProviderWebIss2 : ProviderABRASF2
    {
        #region Constructors

        public ProviderWebIss2(ConfiguracoesNFSe config, ACBrMunicipioNFSe municipio) : base(config, municipio)
        {
            Name = "WebISS2";
        }

        #endregion Constructors

        #region Methods

        protected override IABRASF2Client GetClient(TipoUrl tipo)
        {
            var url = GetUrl(tipo);
            return new WebIss2ServiceClient(url, TimeOut, Certificado);
        }

        protected override string GetNamespace()
        {
            return "http://www.abrasf.org.br/nfse.xsd";
        }

        protected override string GetSchema(TipoUrl tipo)
        {
            return "nfse v2 02.xsd";
        }

        #endregion Methods
    }
}