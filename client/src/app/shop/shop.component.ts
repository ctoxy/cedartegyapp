import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { IBrand } from '../models/brand';
import { IProduct } from '../models/product';
import { IProductType } from '../models/productType';
import { ShopParams } from '../models/shopParams';
import { ShopService } from '../_services/shop.service';

@Component({
  selector: 'app-shop',
  templateUrl: './shop.component.html',
  styleUrls: ['./shop.component.scss']
})
export class ShopComponent implements OnInit {
  @ViewChild('search', {static: true}) searchTerm: ElementRef;
  products: IProduct[] | undefined;
  brands: IBrand[] | undefined;
  productTypes: IProductType[] | undefined;
  shopParams = new ShopParams();
  totalCount: number;
  sortOptions = [
    {name: 'Alphabetical', value:'name'},
    {name: 'Price: Low to High', value:'priceAsc'},
    {name: 'Price: High to Low', value:'priceDesc'}
  ]
  constructor(private shopService: ShopService) { }

  ngOnInit(): void {
    this.getBrands();
    this.getProductTypes();
    this.getProducts();
    
  }

  getProducts() {
    this.shopService.getProducts(this.shopParams).subscribe(response => {
      this.products = response?.data;
      this.shopParams.pageNumber = response?.pageIndex;
      this.totalCount = response?.count;
    }, error => {
      console.log(error);      
    })
  }

  getBrands(){
    this.shopService.getBrands().subscribe(response => {
      this.brands = [{id:0, name: 'All'}, ...response];
    }, error => {
      console.log(error);      
    })
  }
  getProductTypes(){
    this.shopService.getpProductTypes().subscribe(response => {
      this.productTypes = [{id:0, name: 'All'}, ...response];
    }, error => {
      console.log(error);      
    })
  }

  onBrandSelected(brandId: number){
    this.shopParams.brandId = brandId;
    this.shopParams.pageNumber = 1;
    this.getProducts()
  }

  onTypeSelected(typeId: number){
    this.shopParams.typeId = typeId;
    this.shopParams.pageNumber = 1;
    this.getProducts();
  }

  onSortSelected(sort:string){
    this.shopParams.sort = sort;
    this.shopParams.pageNumber = 1;
    this.getProducts();
  }

  onPageChanged(event: any){
    if (this.shopParams.pageNumber !== event) {
      this.shopParams.pageNumber = event;
      this.getProducts();      
    }
    

  }

  onSearch(){
    this.shopParams.search = this.searchTerm.nativeElement.value;
    this.shopParams.pageNumber = 1;
    this.getProducts();
  }

  onReset(){
    this.searchTerm.nativeElement.value = '';
    this.shopParams = new ShopParams();
    this.getProducts();
  }
}
