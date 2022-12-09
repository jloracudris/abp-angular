import { RestService } from '@abp/ng.core';
import { Injectable } from '@angular/core';
import type { IActionResult } from '../../../../../microsoft/asp-net-core/mvc/models';

@Injectable({
  providedIn: 'root',
})
export class HistoryService {
  apiName = 'Default';
  

  handleByDefinitionIdAndCancellationToken = (definitionId: string, cancellationToken?: any) =>
    this.restService.request<any, IActionResult>({
      method: 'GET',
      url: `/v1/workflow-definitions/${definitionId}/history`,
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
