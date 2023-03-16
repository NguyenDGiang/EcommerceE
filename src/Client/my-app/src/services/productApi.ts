import { Product } from './../models/product';

const products : Product[] =[
    {
        id : "a",
        name: "Giang"
    },
    {
        id : "b",
        name: "Giang1"
    }
] 

const productApi = {
  getAll(): Promise<Product[]> {
    const url = '/students';
    return new Promise<Product[]>((resolve, reject) => {
      try{
        resolve(products);
      }
        catch(error){
          reject(error);

        }
    });
  },
}

export default productApi;