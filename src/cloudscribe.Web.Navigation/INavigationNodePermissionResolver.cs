﻿// Copyright (c) Source Tree Solutions, LLC. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
// Author:					Joe Audette
// Created:					2015-07-11
// Last Modified:			2019-07-31
// 

using System.Threading.Tasks;

namespace cloudscribe.Web.Navigation
{
    public interface INavigationNodePermissionResolver
    {
        Task<bool> ShouldAllowView(TreeNode<NavigationNode> menuNode);
    }
}
