export interface WastePickerDto {
  id: number
  firstName: string
  lastName: string
  dob: string | null
  identityNumber: string | null
  otherIdentityNumber: string | null
  age: number
  cellphoneNo: string
  altCellphoneNo: string | null
  potrait: string | null
  wastePickerNo: number
  comment: string | null
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
  documentTypeId: number | null
  wastePickerStatus: string
  gender: string
  genderId: number
  race: string
  raceId: number
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