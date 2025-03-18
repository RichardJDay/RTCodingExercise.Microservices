import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PlatesControlsComponent } from './plates-controls.component';

describe('PlatesControlsComponent', () => {
  let component: PlatesControlsComponent;
  let fixture: ComponentFixture<PlatesControlsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [PlatesControlsComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(PlatesControlsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
