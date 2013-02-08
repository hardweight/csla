﻿//-----------------------------------------------------------------------
// <copyright file="MockMobileList.cs" company="Marimer LLC">
//     Copyright (c) Marimer LLC. All rights reserved.
//     Website: http://www.lhotka.net/cslanet/
// </copyright>
// <summary>no summary</summary>
//-----------------------------------------------------------------------
using System;
using System.Net;
using System.Windows;
#if !__ANDROID__
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
#endif
using Csla;
using Csla.Serialization;

namespace cslalighttest.Serialization
{
  [Serializable]
  public class MockMobileList : Csla.Core.MobileBindingList<MockReadOnly>
  {
    public MockMobileList()
    {
#if SILVERLIGHT
        this.CollectionChanged += (o, e) => {this.HasRaisedOnListChanged = true;};
#else 
        this.ListChanged += (o, e) => {this.HasRaisedOnListChanged = true;};
#endif
    }

    public bool HasRaisedOnListChanged { get; set; }
  }
}