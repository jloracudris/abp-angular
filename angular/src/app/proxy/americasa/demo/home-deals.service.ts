import { RestService } from '@abp/ng.core';
import type { PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';
import type { HomeDealDto } from '../../application/contrats/dto/models';

@Injectable({
  providedIn: 'root',
})
export class HomeDealsService {
  apiName = 'Default';
  

  create = (text: string, apiVersion: string = "1.0") =>
    this.restService.request<any, HomeDealDto>({
      method: 'POST',
      url: '/api/app/home-deals',
      params: { text, ["api-version"]: apiVersion },
    },
    { apiName: this.apiName });
  

  delete = (id: number, apiVersion: string = "1.0") =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/home-deals/${id}`,
      params: { ["api-version"]: apiVersion },
    },
    { apiName: this.apiName });
  

  getList = (apiVersion: string = "1.0") =>
    this.restService.request<any, PagedResultDto<HomeDealDto>>({
      method: 'GET',
      url: '/api/app/home-deals',
      params: { ["api-version"]: apiVersion },
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
