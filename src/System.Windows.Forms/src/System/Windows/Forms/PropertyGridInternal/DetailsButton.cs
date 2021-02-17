﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

namespace System.Windows.Forms.PropertyGridInternal
{
    internal partial class DetailsButton : Button
    {
        private readonly GridErrorDlg parent;

        public DetailsButton(GridErrorDlg form)
        {
            parent = form;
        }

        public bool Expanded
        {
            get
            {
                return parent.DetailsButtonExpanded;
            }
        }
        protected override AccessibleObject CreateAccessibilityInstance()
        {
            return new DetailsButtonAccessibleObject(this);
        }
    }
}
