#region Dapplo 2017 - GNU Lesser General Public License

// Dapplo - building blocks for .NET applications
// Copyright (C) 2017 Dapplo
// 
// For more information see: http://dapplo.net/
// Dapplo repositories are hosted on GitHub: https://github.com/dapplo
// 
// This file is part of Greenshot
// 
// Greenshot is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// Greenshot is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
// 
// You should have a copy of the GNU Lesser General Public License
// along with Greenshot. If not, see <http://www.gnu.org/licenses/lgpl.txt>.

#endregion

#region Usings

using System.Diagnostics.CodeAnalysis;

#endregion

[assembly:
	SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass", Scope = "member",
		Target = "GreenshotPlugin.Core.Accessible.#AccessibleObjectFromWindow(System.IntPtr,System.UInt32,System.Guid&,System.Object&)")]
[assembly:
	SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass", Scope = "member",
		Target = "GreenshotPlugin.Core.Accessible.#AccessibleChildren(Accessibility.IAccessible,System.Int32,System.Int32,System.Object[],System.Int32&)")]
[assembly:
	SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass", Scope = "member",
		Target = "GreenshotPlugin.Core.Accessible.#ObjectFromLresult(System.UIntPtr,System.Guid,System.IntPtr)")]
[assembly:
	SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass", Scope = "member",
		Target = "Greenshot.Interop.COMWrapper.#ProgIDFromCLSID(System.Guid&,System.String&)")]
[assembly:
	SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass", Scope = "member",
		Target = "Greenshot.Interop.COMWrapper.#GetActiveObject(System.Guid&,System.IntPtr,System.Object&)")]
[assembly:
	SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass", Scope = "member",
		Target = "GreenshotPlugin.Core.CredentialsDialog.#DeleteObject(System.IntPtr)")]
[assembly:
	SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass", Scope = "member",
		Target =
			"GreenshotPlugin.Core.CredUi.#PromptForCredentials(GreenshotPlugin.Core.CredUi+INFO&,System.String,System.IntPtr,System.Int32,System.Text.StringBuilder,System.Int32,System.Text.StringBuilder,System.Int32,System.Int32&,GreenshotPlugin.Core.CredUi+CredFlags)"
	)]
[assembly:
	SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass", Scope = "member",
		Target = "GreenshotPlugin.Core.CredUi.#ConfirmCredentials(System.String,System.Boolean)")]
[assembly:
	SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass", Scope = "member",
		Target = "GreenshotPlugin.Controls.HotkeyControl.#RegisterHotKey(System.IntPtr,System.Int32,System.UInt32,System.UInt32)")]
[assembly:
	SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass", Scope = "member",
		Target = "GreenshotPlugin.Controls.HotkeyControl.#UnregisterHotKey(System.IntPtr,System.Int32)")]
[assembly:
	SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass", Scope = "member",
		Target = "GreenshotPlugin.Controls.HotkeyControl.#MapVirtualKey(System.UInt32,System.UInt32)")]
[assembly:
	SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass", Scope = "member",
		Target = "GreenshotPlugin.Controls.HotkeyControl.#GetKeyNameText(System.UInt32,System.Text.StringBuilder,System.Int32)")]
[assembly:
	SuppressMessage("Microsoft.Interoperability", "CA1401:PInvokesShouldNotBeVisible", Scope = "member",
		Target = "GreenshotPlugin.Core.Accessible.#ObjectFromLresult(System.UIntPtr,System.Guid,System.IntPtr)")]
[assembly:
	SuppressMessage("Microsoft.Interoperability", "CA1401:PInvokesShouldNotBeVisible", Scope = "member",
		Target =
			"GreenshotPlugin.Core.CredUi.#PromptForCredentials(GreenshotPlugin.Core.CredUi+INFO&,System.String,System.IntPtr,System.Int32,System.Text.StringBuilder,System.Int32,System.Text.StringBuilder,System.Int32,System.Int32&,GreenshotPlugin.Core.CredUi+CredFlags)"
	)]
[assembly:
	SuppressMessage("Microsoft.Interoperability", "CA1401:PInvokesShouldNotBeVisible", Scope = "member",
		Target = "GreenshotPlugin.Core.CredUi.#ConfirmCredentials(System.String,System.Boolean)")]