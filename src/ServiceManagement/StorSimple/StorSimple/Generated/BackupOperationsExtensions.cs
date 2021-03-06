// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Management.StorSimple;
using Microsoft.WindowsAzure.Management.StorSimple.Models;

namespace Microsoft.WindowsAzure.Management.StorSimple
{
    /// <summary>
    /// This is an RESTFul API to manage you StorSimple Objects
    /// </summary>
    public static partial class BackupOperationsExtensions
    {
        /// <summary>
        /// Begin a backup operation for the policyId and backupRequest
        /// specified.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.StorSimple.IBackupOperations.
        /// </param>
        /// <param name='deviceId'>
        /// Required. The device id for which the call will be made.
        /// </param>
        /// <param name='policyId'>
        /// Required. The policy id for which the call will be made.
        /// </param>
        /// <param name='backupRequest'>
        /// Required. Parameters supplied to the Begin Backup operation.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. The Custom Request Headers which client must use.
        /// </param>
        /// <returns>
        /// This is the Task Response for all Async Calls
        /// </returns>
        public static TaskResponse BeginCreatingBackup(this IBackupOperations operations, string deviceId, string policyId, BackupNowRequest backupRequest, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IBackupOperations)s).BeginCreatingBackupAsync(deviceId, policyId, backupRequest, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Begin a backup operation for the policyId and backupRequest
        /// specified.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.StorSimple.IBackupOperations.
        /// </param>
        /// <param name='deviceId'>
        /// Required. The device id for which the call will be made.
        /// </param>
        /// <param name='policyId'>
        /// Required. The policy id for which the call will be made.
        /// </param>
        /// <param name='backupRequest'>
        /// Required. Parameters supplied to the Begin Backup operation.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. The Custom Request Headers which client must use.
        /// </param>
        /// <returns>
        /// This is the Task Response for all Async Calls
        /// </returns>
        public static Task<TaskResponse> BeginCreatingBackupAsync(this IBackupOperations operations, string deviceId, string policyId, BackupNowRequest backupRequest, CustomRequestHeaders customRequestHeaders)
        {
            return operations.BeginCreatingBackupAsync(deviceId, policyId, backupRequest, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Begin deleting a backup set represented by the backSetId provided.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.StorSimple.IBackupOperations.
        /// </param>
        /// <param name='deviceId'>
        /// Required. The device id for which the call will be made.
        /// </param>
        /// <param name='backupSetId'>
        /// Required. The backup set ID to delete.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. The Custom Request Headers which client must use.
        /// </param>
        /// <returns>
        /// This is the Task Response for all Async Calls
        /// </returns>
        public static TaskResponse BeginDeleting(this IBackupOperations operations, string deviceId, string backupSetId, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IBackupOperations)s).BeginDeletingAsync(deviceId, backupSetId, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Begin deleting a backup set represented by the backSetId provided.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.StorSimple.IBackupOperations.
        /// </param>
        /// <param name='deviceId'>
        /// Required. The device id for which the call will be made.
        /// </param>
        /// <param name='backupSetId'>
        /// Required. The backup set ID to delete.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. The Custom Request Headers which client must use.
        /// </param>
        /// <returns>
        /// This is the Task Response for all Async Calls
        /// </returns>
        public static Task<TaskResponse> BeginDeletingAsync(this IBackupOperations operations, string deviceId, string backupSetId, CustomRequestHeaders customRequestHeaders)
        {
            return operations.BeginDeletingAsync(deviceId, backupSetId, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Begin restoring a backup set.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.StorSimple.IBackupOperations.
        /// </param>
        /// <param name='deviceId'>
        /// Required. The device id for which the call will be made.
        /// </param>
        /// <param name='backupDetailsForRestore'>
        /// Required. The details of the backup to be restored.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. The Custom Request Headers which client must use.
        /// </param>
        /// <returns>
        /// This is the Task Response for all Async Calls
        /// </returns>
        public static TaskResponse BeginRestoring(this IBackupOperations operations, string deviceId, RestoreBackupRequest backupDetailsForRestore, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IBackupOperations)s).BeginRestoringAsync(deviceId, backupDetailsForRestore, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Begin restoring a backup set.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.StorSimple.IBackupOperations.
        /// </param>
        /// <param name='deviceId'>
        /// Required. The device id for which the call will be made.
        /// </param>
        /// <param name='backupDetailsForRestore'>
        /// Required. The details of the backup to be restored.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. The Custom Request Headers which client must use.
        /// </param>
        /// <returns>
        /// This is the Task Response for all Async Calls
        /// </returns>
        public static Task<TaskResponse> BeginRestoringAsync(this IBackupOperations operations, string deviceId, RestoreBackupRequest backupDetailsForRestore, CustomRequestHeaders customRequestHeaders)
        {
            return operations.BeginRestoringAsync(deviceId, backupDetailsForRestore, customRequestHeaders, CancellationToken.None);
        }
        
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.StorSimple.IBackupOperations.
        /// </param>
        /// <param name='deviceId'>
        /// Required. The device id for which the call will be made.
        /// </param>
        /// <param name='policyId'>
        /// Required. The policy id for which the call will be made.
        /// </param>
        /// <param name='backupRequest'>
        /// Required. Parameters supplied to the Begin Backup operation.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. The Custom Request Headers which client must use.
        /// </param>
        /// <returns>
        /// Info about the async task
        /// </returns>
        public static TaskStatusInfo Create(this IBackupOperations operations, string deviceId, string policyId, BackupNowRequest backupRequest, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IBackupOperations)s).CreateAsync(deviceId, policyId, backupRequest, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.StorSimple.IBackupOperations.
        /// </param>
        /// <param name='deviceId'>
        /// Required. The device id for which the call will be made.
        /// </param>
        /// <param name='policyId'>
        /// Required. The policy id for which the call will be made.
        /// </param>
        /// <param name='backupRequest'>
        /// Required. Parameters supplied to the Begin Backup operation.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. The Custom Request Headers which client must use.
        /// </param>
        /// <returns>
        /// Info about the async task
        /// </returns>
        public static Task<TaskStatusInfo> CreateAsync(this IBackupOperations operations, string deviceId, string policyId, BackupNowRequest backupRequest, CustomRequestHeaders customRequestHeaders)
        {
            return operations.CreateAsync(deviceId, policyId, backupRequest, customRequestHeaders, CancellationToken.None);
        }
        
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.StorSimple.IBackupOperations.
        /// </param>
        /// <param name='deviceId'>
        /// Required. The device id for which the call will be made.
        /// </param>
        /// <param name='backupSetId'>
        /// Required. The backup set ID to delete.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. The Custom Request Headers which client must use.
        /// </param>
        /// <returns>
        /// Info about the async task
        /// </returns>
        public static TaskStatusInfo Delete(this IBackupOperations operations, string deviceId, string backupSetId, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IBackupOperations)s).DeleteAsync(deviceId, backupSetId, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.StorSimple.IBackupOperations.
        /// </param>
        /// <param name='deviceId'>
        /// Required. The device id for which the call will be made.
        /// </param>
        /// <param name='backupSetId'>
        /// Required. The backup set ID to delete.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. The Custom Request Headers which client must use.
        /// </param>
        /// <returns>
        /// Info about the async task
        /// </returns>
        public static Task<TaskStatusInfo> DeleteAsync(this IBackupOperations operations, string deviceId, string backupSetId, CustomRequestHeaders customRequestHeaders)
        {
            return operations.DeleteAsync(deviceId, backupSetId, customRequestHeaders, CancellationToken.None);
        }
        
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.StorSimple.IBackupOperations.
        /// </param>
        /// <param name='deviceId'>
        /// Required. The device id for which the call will be made.
        /// </param>
        /// <param name='filterType'>
        /// Optional. If isAllSelected = true, then specify Volume or
        /// BackupPolicy here
        /// </param>
        /// <param name='isAllSelected'>
        /// Required. To retrieve Volume or BackupPolicy or both
        /// </param>
        /// <param name='filterValue'>
        /// Optional. If isAllSelected = true then specify VolumeId or
        /// BackupPolicy here
        /// </param>
        /// <param name='startTime'>
        /// Optional. StartTime for filtering BackupSets
        /// </param>
        /// <param name='endTime'>
        /// Optional. EndTime for filtering BackupSets
        /// </param>
        /// <param name='skip'>
        /// Optional. Number of elements to be skipped as part of pagination
        /// </param>
        /// <param name='top'>
        /// Optional. Number of elements to retrieve in the current page
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. The Custom Request Headers which client must use.
        /// </param>
        /// <returns>
        /// The response model for the list of BackupSets.
        /// </returns>
        public static GetBackupResponse Get(this IBackupOperations operations, string deviceId, string filterType, string isAllSelected, string filterValue, string startTime, string endTime, string skip, string top, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IBackupOperations)s).GetAsync(deviceId, filterType, isAllSelected, filterValue, startTime, endTime, skip, top, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.StorSimple.IBackupOperations.
        /// </param>
        /// <param name='deviceId'>
        /// Required. The device id for which the call will be made.
        /// </param>
        /// <param name='filterType'>
        /// Optional. If isAllSelected = true, then specify Volume or
        /// BackupPolicy here
        /// </param>
        /// <param name='isAllSelected'>
        /// Required. To retrieve Volume or BackupPolicy or both
        /// </param>
        /// <param name='filterValue'>
        /// Optional. If isAllSelected = true then specify VolumeId or
        /// BackupPolicy here
        /// </param>
        /// <param name='startTime'>
        /// Optional. StartTime for filtering BackupSets
        /// </param>
        /// <param name='endTime'>
        /// Optional. EndTime for filtering BackupSets
        /// </param>
        /// <param name='skip'>
        /// Optional. Number of elements to be skipped as part of pagination
        /// </param>
        /// <param name='top'>
        /// Optional. Number of elements to retrieve in the current page
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. The Custom Request Headers which client must use.
        /// </param>
        /// <returns>
        /// The response model for the list of BackupSets.
        /// </returns>
        public static Task<GetBackupResponse> GetAsync(this IBackupOperations operations, string deviceId, string filterType, string isAllSelected, string filterValue, string startTime, string endTime, string skip, string top, CustomRequestHeaders customRequestHeaders)
        {
            return operations.GetAsync(deviceId, filterType, isAllSelected, filterValue, startTime, endTime, skip, top, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Restore a backup set.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.StorSimple.IBackupOperations.
        /// </param>
        /// <param name='deviceId'>
        /// Required. The device id for which the call will be made.
        /// </param>
        /// <param name='backupDetailsForRestore'>
        /// Required. The details of the backup to be restored.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. The Custom Request Headers which client must use.
        /// </param>
        /// <returns>
        /// Info about the async task
        /// </returns>
        public static TaskStatusInfo Restore(this IBackupOperations operations, string deviceId, RestoreBackupRequest backupDetailsForRestore, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IBackupOperations)s).RestoreAsync(deviceId, backupDetailsForRestore, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Restore a backup set.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.StorSimple.IBackupOperations.
        /// </param>
        /// <param name='deviceId'>
        /// Required. The device id for which the call will be made.
        /// </param>
        /// <param name='backupDetailsForRestore'>
        /// Required. The details of the backup to be restored.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. The Custom Request Headers which client must use.
        /// </param>
        /// <returns>
        /// Info about the async task
        /// </returns>
        public static Task<TaskStatusInfo> RestoreAsync(this IBackupOperations operations, string deviceId, RestoreBackupRequest backupDetailsForRestore, CustomRequestHeaders customRequestHeaders)
        {
            return operations.RestoreAsync(deviceId, backupDetailsForRestore, customRequestHeaders, CancellationToken.None);
        }
    }
}
