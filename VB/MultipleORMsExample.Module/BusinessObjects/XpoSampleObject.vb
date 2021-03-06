﻿Imports System.Linq
Imports System.Text
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Xpo
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.DC

Namespace MultipleORMsExample.Module.BusinessObjects
    <DefaultClassOptions> _
    Public Class XpoSampleObject
        Inherits BaseObject

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
'INSTANT VB NOTE: The variable name was renamed since Visual Basic does not allow variables and other class members to have the same name:
        Private _name As String
        Public Property Name() As String
            Get
                Return _name
            End Get
            Set(ByVal value As String)
                SetPropertyValue("Name", _name, value)
            End Set
        End Property
'INSTANT VB NOTE: The variable description was renamed since Visual Basic does not allow variables and other class members to have the same name:
        Private _description As String
        <Size(SizeAttribute.Unlimited)> _
        Public Property Description() As String
            Get
                Return _description
            End Get
            Set(ByVal value As String)
                SetPropertyValue("Description", _description, value)
            End Set
        End Property
    End Class
End Namespace
