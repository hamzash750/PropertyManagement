import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PropertSubmission3Component } from './propert-submission3.component';

describe('PropertSubmission3Component', () => {
  let component: PropertSubmission3Component;
  let fixture: ComponentFixture<PropertSubmission3Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PropertSubmission3Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PropertSubmission3Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
