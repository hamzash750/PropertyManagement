export class propertyAdd {
    id!: number;
    tittle!: string;
    images!: string;
    description!: string;
    areaUnit!: string;
    area!: string;
    location!: string;
    price!: string;
    postDate!: string;
    category!: string;
    email!: string;
    phone!: string;
    address!: string;
    userName!: string;
    quantity!: number;
    sellerId!: number;
    categoryId!: number;
    bed!: number;
    baths!: number;
    garage!: boolean;
    pool!: boolean;
    otherAmenites!: string;
}
export class propertyReview {
    rate!: number;
    user!: string;
    reviewTittle!: string;
    reviewComents!: string;
    createAt!: Date;
}