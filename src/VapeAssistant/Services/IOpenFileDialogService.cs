﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IOpenFileDialogService.cs" company="bitterskittles">
//   Copyright © 2013 bitterskittles.
//   This program is free software. It comes without any warranty, to
//   the extent permitted by applicable law. You can redistribute it
//   and/or modify it under the terms of the Do What The Fuck You Want
//   To Public License, Version 2, as published by Sam Hocevar. See
//   http://www.wtfpl.net/ for more details.
// </copyright>
// <summary>
//   Defines the IOpenFileDialogService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NVaporWare.VapeAssistant.Services
{
    using System;
    using System.Diagnostics.Contracts;

    [ContractClass(typeof(IOpenFileDialogServiceContract))]
    public interface IOpenFileDialogService
    {
        #region Public Properties

        string FileName { get; }

        #endregion

        #region Public Methods and Operators

        bool ShowDialog();

        #endregion
    }

    [ContractClassFor(typeof(IOpenFileDialogService))]
    public abstract class IOpenFileDialogServiceContract : IOpenFileDialogService
    {
        #region Public Properties

        public string FileName
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        #endregion

        #region Public Methods and Operators

        public bool ShowDialog()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}