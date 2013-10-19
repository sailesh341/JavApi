/*
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *  you may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at 
 * 
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License.
 */
using System;
using java = biz.ritter.javapi;

namespace biz.ritter.javapi.lang{

/**
 * Thrown when the virtual machine notices that an attempt is made to load a
 * class which would directly or indirectly inherit from one of its subclasses.
 * <p>
 * Note that this error can only occur when inconsistent class files are loaded,
 * since it would normally be detected at compile time.
 */
public class ClassCircularityError : LinkageError {

    private const long serialVersionUID = 1054362542914539689L;

    /**
     * Constructs a new {@code ClassCircularityError} that include the current
     * stack trace.
     */
    public ClassCircularityError() :base(){
        
    }

    /**
     * Constructs a new {@code ClassCircularityError} with the current stack
     * trace and the specified detail message.
     * 
     * @param detailMessage
     *            the detail message for this error.
     */
    public ClassCircularityError(String detailMessage) :base(detailMessage){
        
    }
}
}