export interface WastePickerDto {
  id: number
  firstName: string
  lastName: string
  dob: string
  identityNumber: string
  otherIdentityNumber: string
  age: number
  cellphoneNo: string
  altCellphoneNo: string
  potrait: string
  wastePickerNo: number
  comment: string
  consent: number
  createdBy: string
  createdDate: string
  lastUpdatedBy: string
  lastUpdatedDate: string
  registrationLocation: string
  isMemberCooperative: boolean
  activityStatusId: number
  lastActivityDate: string
  printCount: number
  manualPrintCount: number
  autoPrintCount: number
  documentType: string
  documentTypeId: string
  wastePickerStatus: string
  gender: string
  genderId: string
  race: string
  raceId: string
  cooperative: string
}

export interface GenderDto {
    value: any
    id: number
    name: string
}

export interface RaceDto {
    id: number
    name: string
}

export interface WastePickerStatusDto {
    id: number
    name: string
    code: string
}

export interface DocumentTypeDto {
    id: number
    docType: string
    masterCodeId: number
    masterCode: any
}