import type { AuditedEntityDto } from '@abp/ng.core';

export interface SchemaFormDto extends AuditedEntityDto<string> {
  propertyBinding?: string;
  title?: string;
  type?: string;
}
