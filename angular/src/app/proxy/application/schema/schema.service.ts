import { RestService } from '@abp/ng.core';
import type { PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';
import type { CreateUpdateSchemaDto } from '../contrats/schema/models';
import type { SchemaFormDto } from '../../schema/models';

@Injectable({
  providedIn: 'root',
})
export class SchemaService {
  apiName = 'Default';
  

  create = (input: CreateUpdateSchemaDto, apiVersion: string = "1.0") =>
    this.restService.request<any, SchemaFormDto>({
      method: 'POST',
      url: '/api/app/schema',
      params: { ["api-version"]: apiVersion },
      body: input,
    },
    { apiName: this.apiName });
  

  delete = (id: string, apiVersion: string = "1.0") =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/schema/${id}`,
      params: { ["api-version"]: apiVersion },
    },
    { apiName: this.apiName });
  

  get = (id: string, apiVersion: string = "1.0") =>
    this.restService.request<any, SchemaFormDto>({
      method: 'GET',
      url: `/api/app/schema/${id}`,
      params: { ["api-version"]: apiVersion },
    },
    { apiName: this.apiName });
  

  getList = (input: PagedAndSortedResultRequestDto, apiVersion: string = "1.0") =>
    this.restService.request<any, PagedResultDto<SchemaFormDto>>({
      method: 'GET',
      url: '/api/app/schema',
      params: { skipCount: input.skipCount, maxResultCount: input.maxResultCount, sorting: input.sorting, ["api-version"]: input },
    },
    { apiName: this.apiName });
  

  update = (id: string, input: CreateUpdateSchemaDto, apiVersion: string = "1.0") =>
    this.restService.request<any, SchemaFormDto>({
      method: 'PUT',
      url: `/api/app/schema/${id}`,
      params: { ["api-version"]: apiVersion },
      body: input,
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
