/*
 * Licensed to the Apache Software Foundation (ASF) under one or more
 * contributor license agreements. See the NOTICE file distributed with this
 * work for additional information regarding copyright ownership. The ASF
 * licenses this file to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 * http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
 * License for the specific language governing permissions and limitations under
 * the License.
 */

namespace biz.ritter.javapi.lang.annotation
{
	/**
 * Defines a meta-annotation for determining the scope of retention for an
 * annotation. If the retention annotation is not set {@code
 * RetentionPolicy.CLASS} is used as default retention.
 *
 * @see RetentionPolicy
 * @since 1.5
 */
	[Documented]
	[Retention (RetentionPolicy.RUNTIME)]
	[Target (ElementType.ANNOTATION_TYPE)]
	public class Retention : AbstractAnnotation
	{
		private RetentionPolicy policy;

		public Retention (RetentionPolicy newPolicy)
		{
			this.policy = newPolicy;
		}

		/**
     * Returns the retention policy for the annotation.
     * 
     * @return a retention policy as defined in {@code RetentionPolicy}
     */
		public virtual RetentionPolicy value ()
		{
			return this.policy;
		}
	}
}