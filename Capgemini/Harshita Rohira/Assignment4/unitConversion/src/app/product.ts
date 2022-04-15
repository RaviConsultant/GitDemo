export class Product {
  id: number;
  title: string;
  desc: string;
  salePrice: number;
  current_stock: number;

  constructor() {
    this.id = 0;
    this.title = "";
    this.desc = "";
    this.salePrice = 0;
    this.current_stock = 0;
   }
}
