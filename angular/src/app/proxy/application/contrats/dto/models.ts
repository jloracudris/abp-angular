
export interface DealerShipDto {
  id: number;
  name?: string;
}

export interface HomeDealDto {
  dealId: number;
  name?: string;
  phoneNumber?: string;
  email?: string;
  lotNumber?: string;
  houseName?: string;
  boxSize?: string;
  windZone?: string;
  attachment?: string;
  homeStatusId: number;
  lotStatusId: number;
  creationTime?: string;
  updateTime?: string;
}

export interface HomeDto {
  id: number;
  name?: string;
  homeStatusId: number;
  creationTime?: string;
  updateTime?: string;
}

export interface HomeStatusDto {
  name?: string;
  creationTime?: string;
  updateTime?: string;
}

export interface LotStatusDto {
  name?: string;
  id: number;
  creationTime?: string;
  updateTime?: string;
}
