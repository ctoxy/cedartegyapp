import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { delay, map } from 'rxjs';
import { IBrand } from '../models/brand';
import { IPaginationProduct } from '../models/paginationProduct';
import { IProduct } from '../models/product';
import { IProductType } from '../models/productType';
import { ShopParams } from '../models/shopParams';

@Injectable({
  providedIn: 'root'
})
export class ShopService {
  baseUrl = 'https://localhost:5001/api/';
  constructor(private http: HttpClient) { }

  getProducts(shopParams: ShopParams) {
    let params = new HttpParams();

    if (shopParams.brandId !== 0) {
      params = params.append('brandId', shopParams.brandId.toString());
    }

    if (shopParams.typeId !== 0) {
      params = params.append('typeId', shopParams.typeId.toString());
    }

    if (shopParams.search) {
      params = params.append('search', shopParams.search);
    }

    
    params = params.append('sort', shopParams.sort);
    params = params.append('pageIndex', shopParams.pageNumber.toString());
    params = params.append('pageNumber', shopParams.pageSize.toString());

    

    return this.http.get<IPaginationProduct>(this.baseUrl + 'products', {observe:'response', params})
      .pipe(
        //delay(1000),
        map(response => {
          return response.body;
        })
      );
  }

  getProduct(id:number){
    return this.http.get<IProduct>(this.baseUrl + 'products/' + id);
  }

  getBrands(){
    return this.http.get<IBrand[]>(this.baseUrl + 'products/brands');
  }

  getpProductTypes(){
    return this.http.get<IProductType[]>(this.baseUrl + 'products/types');
  }
}
