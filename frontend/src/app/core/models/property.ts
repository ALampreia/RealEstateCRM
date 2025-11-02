import { Address } from '/address';

export interface property
{
    id: string
    title: string
    description: string
    address: Address
    price: number
    bathrooms: number
    rooms: number
    propertyArea: number
    totalArea: number
    yearbuilt?: number
    
}