﻿/*
 * Copyright 2014 DB Systel GmbH
 *
 *	Licensed under the Apache License, Version 2.0 (the "License");
 *	you may not use this file except in compliance with the License.
 *	You may obtain a copy of the License at
 *
 *		http://www.apache.org/licenses/LICENSE-2.0
 *
 *		Unless required by applicable law or agreed to in writing, software
 *		distributed under the License is distributed on an "AS IS" BASIS,
 *		WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *		See the License for the specific language governing permissions and
 *		limitations under the License.
 */
 
using System;
using System.Collections.Generic;

namespace strange.extensions.implicitBind.api
{
	public interface ITypeRegistry
	{
		/// <summary>
		/// Register a new type with this registry
		/// </summary>
		/// <param name="newType"> Type to register</param>
		void RegisterType(Type newType);

		/// <summary>
		/// Register several new types with this registry
		/// </summary>
		/// <param name="newTypes">Collection of types to register</param>
		void RegisterTypes(IEnumerable<Type> newTypes);

		/// <summary>
		/// Return a collection of registered types
		/// </summary>
		/// <returns>Collection of registered types</returns>
		IEnumerable<Type> GetRegisteredTypes();
		
	}
}